using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OmegaGraph
{
  public class OGraph
  {
    #region Private Members ...

    private Vertices vertices;
    private Edges edges;

    #endregion

    #region Enumerations ...

    public enum OptimalType
    {
      Minimum = 0,
      Maximum
    }

    public enum SortType
    {
      Ascending = 0,
      Descending
    };

    #endregion

    #region Public Properties ...

    public Vertices Vertices
    {
      get { return this.vertices; }
    }

    public Edges Edges
    {
      get { return this.edges; }
    }

    #endregion

    #region Constructors ...

    public OGraph()
    {
      this.vertices = new Vertices(this.edges);
      this.edges = new Edges(this.vertices);
    }

    #endregion

    #region Public Methods ...

    /// <summary>
    /// Combines this graph with another one
    /// </summary>
    /// <param name="graph">the second graph</param>
    public void CombineWith(OGraph graph)
    {
      CombineWith(graph, null);
    }

    /// <summary>
    /// Combines this graph with another one through a specific edge
    /// </summary>
    /// <param name="graph">the second graph</param>
    /// <param name="edge">the edge</param>
    public void CombineWith(OGraph graph, Edge edge)
    {
      foreach (int v in graph.Vertices)
      {
        if (!Vertices.Contains(v))
        {
          Vertices.Add(v);
        }
      }

      foreach (Edge e in graph.Edges)
      {
        if (!Edges.Contains(e))
        {
          Edges.Add(e);
        }
      }

      if (edge != null && !Edges.Contains(edge))
      {
        Edges.Add(edge);
      }
    }

    /// <summary>
    /// Clears all vertices & edges
    /// </summary>
    public void Clear()
    {
      // we do not need to remove the edges, because
      // this function will do this for us
      this.Vertices.RemoveAll();
    }

    #endregion
  }  
}
