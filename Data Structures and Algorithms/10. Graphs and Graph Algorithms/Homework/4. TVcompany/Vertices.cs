using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OmegaGraph
{
  public class Vertices : IEnumerable
  {
    #region Private Members ...

    private ArrayList vertices;
    private Edges edges;

    #endregion

    #region Public Properties ...

    public int this[int index]
    {
      get { return (int)this.vertices[index]; }
    }

    public int Count
    {
      get { return this.vertices.Count; }
    }

    #endregion

    #region Constructors ...

    public Vertices(Edges edges)
    {
      this.vertices = new ArrayList();
      this.edges = edges;
    }

    #endregion

    #region Public Methods ...

    /// <summary>
    /// Adds a vertex to the graph
    /// </summary>
    /// <param name="vertex">the vertex</param>
    public void Add(int vertex)
    {
      if (this.vertices.Contains(vertex))
        throw new VertexExistsException();

      this.vertices.Add(vertex);
    }

    /// <summary>
    /// Adds an array ot vertices to the graph
    /// </summary>
    /// <param name="vertices">the vertices</param>
    public void Add(int[] vertices)
    {
      foreach (int v in vertices)
      {
        Add(v);
      }
    }

    /// <summary>
    /// Adds a new vertex to the graph
    /// </summary>
    public void Add()
    {
      for (int i = 0; i <= this.vertices.Count; i++)
      {
        if (!this.vertices.Contains(i))
        {
          Add(i);
          break;
        }
      }
    }

    /// <summary>
    /// Removes a vertex
    /// </summary>
    /// <param name="vertex">the vertex</param>
    public void Remove(int vertex)
    {
      this.vertices.Remove(vertex);
    }

    /// <summary>
    /// Removes all vertices
    /// </summary>
    public void RemoveAll()
    {
      this.vertices.Clear();
      this.edges.RemoveAll();
    }

    /// <summary>
    /// Check if the graph contains a vertex
    /// </summary>
    /// <param name="vertex">the vertex</param>
    /// <returns>TRUE if the graph contains the vertex</returns>
    public bool Contains(int vertex)
    {
      return this.vertices.Contains(vertex);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      foreach (int vertex in this.vertices)
        yield return vertex;
    }

    public override string ToString()
    {
      return this.vertices.ToString();
    }

    public int[] ToArray()
    {
      return (int[])this.vertices.ToArray(typeof(int));
    }

    #endregion
  }
}
