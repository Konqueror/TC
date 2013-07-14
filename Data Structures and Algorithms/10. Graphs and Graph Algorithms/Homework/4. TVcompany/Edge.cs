using System;
using System.Collections.Generic;
using System.Text;

namespace OmegaGraph
{
  public class Edge : IComparable
  {
    #region Private Members ...

    private int source;
    private int target;
    private int value;

    #endregion

    #region Public Properties ...

    public int Source
    {
      get { return this.source; }
      set { this.source = value; }
    }

    public int Target
    {
      get { return this.target; }
      set { this.target = value; }
    }

    public int Value
    {
      get { return this.value; }
      set { this.value = value; }
    }

    #endregion

    #region Constructors ...

    public Edge(int source, int target)
    {
      this.source = source;
      this.target = target;
      this.value = 0;
    }

    public Edge(int source, int target, int value)
    {
      this.source = source;
      this.target = target;
      this.value = value;
    }

    #endregion

    #region Public Methods ...

    public override bool Equals(object obj)
    {
      if (obj.GetType() != typeof(Edge))
        throw new ArgumentException("Cannot compare to an object different from Edge!");

      Edge edge = (Edge)obj;

      return (this.Target == edge.Target && this.Source == edge.Source) ||
        (this.Target == edge.Source && this.Source == edge.Target);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(this.Source);
      sb.Append("->");
      sb.Append(this.Target);

      if (this.Value != 0)
      {
        sb.Append(": ");
        sb.Append(this.Value);
      }

      return sb.ToString();
    }

    public int CompareTo(object obj)
    {
      if (obj.GetType() != typeof(Edge))
        throw new ArgumentException("Cannot compare to an object different from Edge!");

      Edge e = (Edge)obj;

      if (this.Value > e.Value) return 1;
      else if (this.Value < e.Value) return -1;
      else return 0;
    }

    #endregion
  }
}
