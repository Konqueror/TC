using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OmegaGraph
{
  public class GraphAlgorithm
  {
    #region Private Members ...

    private OGraph graph;

    #endregion

    #region Enumerations ...

    public enum AlgorithmType
    {
      Prim = 0,
      Kruskal
    };

    public enum TreeType
    {
      Wide = 0,
      Deep
    }

    #endregion

    #region Constructors ...

    public GraphAlgorithm(OGraph graph)
    {
      this.graph = graph;
    }

    #endregion

    #region Public Methods ...

    /// <summary>
    /// Creates a spanning tree
    /// </summary>
    /// <param name="treeType">wide / deep</param>
    /// <returns>a spanning tree</returns>
    public OGraph CreateSpanningTree(TreeType treeType)
    {
      OGraph tree = new OGraph();
      int firstVertex = this.graph.Vertices[0];

      tree.Vertices.Add(firstVertex);

      if (treeType == TreeType.Wide)
      {
        ArrayList lastLevel = new ArrayList();

        lastLevel.Add(firstVertex);

        while (tree.Vertices.Count != this.graph.Vertices.Count)
        {
          ArrayList newLevel = new ArrayList();

          foreach (Edge e in this.graph.Edges)
          {
            if (lastLevel.Contains(e.Source) && !tree.Vertices.Contains(e.Target))
            {
              newLevel.Add(e.Target);
              tree.Vertices.Add(e.Target);
              tree.Edges.Add(e);
            }
            else if (lastLevel.Contains(e.Target) && !tree.Vertices.Contains(e.Source))
            {
              newLevel.Add(e.Source);
              tree.Vertices.Add(e.Source);
              tree.Edges.Add(e.Target, e.Source);
            }
          }
          
          lastLevel.Clear();
          lastLevel.AddRange(newLevel.ToArray());
        }
      }
      else
      {
        Hashtable parent = new Hashtable(this.graph.Vertices.Count);
        int currectVertex = firstVertex;
        bool edgeFound;

        parent[currectVertex] = null;

      findEdge:
        do
        {
          edgeFound = false;

          foreach (int v in this.graph.Vertices)
          {
            if (!tree.Vertices.Contains(v) && this.graph.Edges.Contains(currectVertex, v))
            {
              tree.Vertices.Add(v);
              tree.Edges.Add(currectVertex, v);
              parent[v] = currectVertex;
              currectVertex = v;
              edgeFound = true;
              break;
            }
          }
        }
        while (edgeFound);

        if (currectVertex != firstVertex)
        {
          currectVertex = (int)parent[currectVertex];
          goto findEdge;
        }
      }

      return tree;
    }

    /// <summary>
    /// Creates a optimal spanning tree based on a algorithm
    /// </summary>
    /// <param name="optimalType">Min / Max</param>
    /// <param name="algorithm">Kruskal / Prim</param>
    /// <returns>an optimal spanning tree</returns>
    public OGraph CreateOptimalSpanningTree(OGraph.OptimalType optimalType, AlgorithmType algorithm)
    {
      //
      // Kruskal's algorithm
      //
      if (algorithm == AlgorithmType.Kruskal)
      {
        // first we sort the edges on their values
        this.graph.Edges.Sort();

        // we create a tree, which contains only one vertex 
        // (from the graph vertices) and no edges
        ArrayList trees = new ArrayList(this.graph.Vertices.Count);

        foreach (int v in this.graph.Vertices)
        {
          OGraph g = new OGraph();
          g.Vertices.Add(v);

          trees.Add(g);
        }

        // we perform these steps while we get only one tree left
        while (trees.Count > 1)
        {
          // we search for an edge with Source Vertex & 
          // Target Vertex in different trees and then we combine these trees
          // into one tree
          foreach (Edge g in this.graph.Edges)
          {
            OGraph tree = null;
            OGraph tree2 = null;
            
            // searching for the first tree ...
            foreach (OGraph t in trees)
            {
              if ((t.Vertices.Contains(g.Source) && !t.Vertices.Contains(g.Target)) ||
                (!t.Vertices.Contains(g.Source) && t.Vertices.Contains(g.Target)))
              {
                tree = t;
                break;
              }
            }

            // if there is a tree containg both the source & target vertices
            // we begin searching for trees with the next edge
            if (tree == null) continue;

            // we remove the found tree from the collection
            // because we are going to search the collection once more
            // in order to find a second tree containg only one ot the edge's vertices
            trees.Remove(tree);

            // looking for the second tree ...
            foreach (OGraph t in trees)
            {
              if ((t.Vertices.Contains(g.Source) || t.Vertices.Contains(g.Target)) &&
                !t.Edges.Contains(g))
              {
                tree2 = t;
                break;
              }
            }

            //if (tree2 == null) break;

            // combine first tree with this
            ((OGraph)trees[trees.IndexOf(tree2)]).CombineWith(tree, g);          

            // if we have only one tree lest - OK, we're done!
            if (trees.Count == 1) break;
          }
        }

        return (OGraph)trees[0];
      }

      //
      // Prim's algorithm
      //
      else
      {
        // our spanning tree
        OGraph tree = new OGraph();

        // a collection of all vertices of the graph
        ArrayList vertices = new ArrayList(this.graph.Vertices.Count);
        vertices.AddRange(this.graph.Vertices.ToArray());

        // we remove the first vertex of the graph and add it
        // to our collection
        tree.Vertices.Add((int)vertices[0]);
        vertices.RemoveAt(0);

        // we perform these steps while we have vertices left
        // in our collection
        while (vertices.Count > 0)
        {
          Edge optEdge = null;

          foreach (Edge e in this.graph.Edges)
          {
            // we are searching for an optimal edge with only one
            // end in our vertices collection
            if ((vertices.Contains(e.Source) && !vertices.Contains(e.Target)) ||
              (vertices.Contains(e.Target) && !vertices.Contains(e.Source)))
            {
              if (optEdge == null ||
                (optimalType == OGraph.OptimalType.Minimum && e.CompareTo(optEdge) < 0) ||
                (optimalType == OGraph.OptimalType.Maximum && e.CompareTo(optEdge) > 0))
              {
                optEdge = e;
              }
            }
          }

          // we have found an edge ...
          if (optEdge != null)
          {
            // the vertex which our collection contains
            int vertex = -1;

            if (vertices.Contains(optEdge.Source)) vertex = optEdge.Source;
            else vertex = optEdge.Target;

            // we remove this vertex and add it to the tree vertices
            // we also add the optimal edge to the tree
            vertices.Remove(vertex);
            tree.Vertices.Add(vertex);
            tree.Edges.Add(optEdge);
          }
        }

        return tree;
      }
    }

    /// <summary>
    /// Creates an optimal value tree based on Dijkstra algorithm
    /// </summary>
    /// <param name="optimalType">Min / Max</param>
    /// <returns>the optimal value tree</returns>
    public OGraph CreateValueTree(OGraph.OptimalType optimalType)
    {
      // vertices count
      int verticesCount = this.graph.Vertices.Count;

      // contains the optimal value from the first vertex
      // to another one
      Hashtable dist = new Hashtable(verticesCount);

      // contains the father of the specific vertex
      Hashtable part = new Hashtable(verticesCount);

      // first vertex
      int firstVertex = (int)this.graph.Vertices[0];

      foreach (int v in this.graph.Vertices)
      {
        if (firstVertex != v)
        {
          // every vertes has initial father -> the first vertex
          part[v] = firstVertex;

          // from the first vertex to [v]
          dist[v] = this.edgeValue(firstVertex, v);
        }
        else
        {
          dist[firstVertex] = 0; // value of the edge [x,x] is always 0
          part[firstVertex] = -1; // first vertex has no father
        }
      }

      // our collection of the graph's vertices
      ArrayList vertices = new ArrayList(this.graph.Vertices.Count);
      vertices.AddRange(this.graph.Vertices.ToArray());

      // we remove the first vertex from the collection
      vertices.Remove(firstVertex);
      verticesCount--;

      // we perform these steps [verticesCount] times
      for (int i = 0; i < verticesCount; i++)
      {
        int j = this.optimalElement(vertices, dist, optimalType);
        vertices.Remove(j);

        if (optimalType == OGraph.OptimalType.Minimum)
        {
          foreach (int v in vertices)
          {
            int o = (int)dist[j] + this.edgeValue(j, v);

            if (o.CompareTo(dist[v]) < 0)
            {
              part[v] = j;
              dist[v] = o;
            }
          }
        }
        else
        {
          foreach (int v in vertices)
          {
            int o = (int)dist[j] + this.edgeValue(j, v);

            if (o.CompareTo(dist[v]) > 0)
            {
              part[v] = j;
              dist[v] = o;
            }
          }
        }
      }

      OGraph tree = new OGraph();
      tree.Vertices.Add(this.graph.Vertices.ToArray());

      foreach (DictionaryEntry de in part)
      {
        if (!de.Value.Equals(-1))
        {
          Edge e = new Edge((int)de.Value, (int)de.Key, (int)dist[de.Key]);
          tree.Edges.Add(e);
        }
      }

      return tree;
    }

    /// <summary>
    /// Gets the element with optimal value
    /// </summary>
    /// <param name="vertices">vertices collection</param>
    /// <param name="dist">temp value collection</param>
    /// <param name="optimalType">Min / Max</param>
    /// <returns>index of the optimal element in DIST collection</returns>
    private int optimalElement(ArrayList vertices, Hashtable dist, OGraph.OptimalType optimalType)
    {
      int optElement = (int)vertices[0];
      int optValue = (int)dist[optElement];

      if (optimalType == OGraph.OptimalType.Minimum)
      {
        foreach (int v in vertices)
        {
          if (optValue.CompareTo(dist[v]) > 0)
          {
            optValue = (int)dist[v];
            optElement = v;
          }
        }
      }
      else
      {
        foreach (int v in vertices)
        {
          if (optValue.CompareTo(dist[v]) < 0)
          {
            optValue = (int)dist[v];
            optElement = v;
          }
        }
      }

      return optElement;
    }

    /// <summary>
    /// Gets the value of an edge
    /// </summary>
    /// <param name="i">source vertex</param>
    /// <param name="j">target vertex</param>
    /// <returns>the value of the edge</returns>
    private int edgeValue(int i, int j)
    {
      return this.graph.Edges.Contains(i, j) ? 
        this.graph.Edges.EdgeValue(i, j) : this.graph.Edges.Value + 10;
    }

    #endregion
  }
}
