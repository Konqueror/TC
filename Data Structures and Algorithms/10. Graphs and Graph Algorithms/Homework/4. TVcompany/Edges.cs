using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OmegaGraph
{
  public class Edges : IEnumerable
  {
    #region Private Members ...

    private ArrayList edges;
    private Vertices vertices;

    #endregion

    #region Public Properties ...

    public Edge this[int index]
    {
      get { return (Edge)this.edges[index]; }
    }

    public int Count
    {
      get { return this.edges.Count; }
    }

    public int Value
    {
      get
      {
        int sum = 0;

        foreach (Edge e in this.edges)
          sum += e.Value;

        return sum;
      }
    }

    #endregion

    #region Constructors ...

    public Edges(Vertices vertices)
    {
      this.edges = new ArrayList();
      this.vertices = vertices;
    }

    #endregion

    #region Public Methods ...

    /// <summary>
    /// Adds an edge to the graph
    /// </summary>
    /// <param name="edge">the edge</param>
    public void Add(Edge edge)
    {
      if (!this.vertices.Contains(edge.Source) || !this.vertices.Contains(edge.Target))
        throw new VertexDoesNotExistsException("You must first add the source & target vertices to the graph!");

      this.edges.Add(edge);
    }

    /// <summary>
    /// Adds an edge to the graph
    /// </summary>
    /// <param name="sourceVertex">source vertex</param>
    /// <param name="targetVertex">target vertex</param>
    public void Add(int sourceVertex, int targetVertex)
    {
      Add(new Edge(sourceVertex, targetVertex));
    }

    /// <summary>
    /// Removes an edge
    /// </summary>
    /// <param name="edge">the edge</param>
    public void Remove(Edge edge)
    {
      this.edges.Remove(edge);
    }

    /// <summary>
    /// Removes all edges
    /// </summary>
    public void RemoveAll()
    {
      this.edges.Clear();
    }

    /// <summary>
    /// Check if the graph contains a specific edge
    /// </summary>
    /// <param name="edge">the edge</param>
    /// <returns>TRUE if the graph contains the edge</returns>
    public bool Contains(Edge edge)
    {
      return this.edges.Contains(edge);
    }

    /// <summary>
    /// Check if the graph contains a specific edge
    /// </summary>
    /// <param name="i">source vertex</param>
    /// <param name="j">target vertex</param>
    /// <returns>TRUE if the graph contains the edge</returns>
    public bool Contains(int i, int j)
    {
      return Contains(new Edge(i, j));
    }

    /// <summary>
    /// Gets the edge value
    /// </summary>
    /// <param name="i">source vertex</param>
    /// <param name="j">target vertex</param>
    /// <returns>Edge value</returns>
    public int EdgeValue(Edge edge)
    {
      if (Contains(edge))
      {
        int i = this.edges.IndexOf(edge);

        return ((Edge)this.edges[i]).Value;
      }
      else
      {
        return 0;
      }
    }

    /// <summary>
    /// Gets the edge value
    /// </summary>
    /// <param name="i">source vertex</param>
    /// <param name="j">target vertex</param>
    /// <returns>Edge value</returns>
    public int EdgeValue(int i, int j)
    {
      return EdgeValue(new Edge(i, j));
    }

    /// <summary>
    /// Sorts the edges compared to their values
    /// </summary>
    public void Sort()
    {
      this.edges.Sort();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      foreach (Edge e in this.edges)
        yield return e;
    }

    public Edge[] ToArray()
    {
      return (Edge[])this.edges.ToArray(typeof(Edge));
    }

    #endregion

    internal Edge FindEdgeBeginningIn(int vertex)
    {
      foreach(Edge e in this.edges)
      {
        if (e.Source == vertex || e.Target == vertex)
          return e;
      }

      return null;
    }
  }
}
