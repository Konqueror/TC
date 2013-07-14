using System;
using System.Collections.Generic;
using System.Text;

namespace OmegaGraph
{
  public class VertexDoesNotExistsException : Exception
  {
    public VertexDoesNotExistsException(string message, Exception causeException)
      : base(message, causeException)
    {
      //~
    }

    public VertexDoesNotExistsException(string message)
      : this(message, null)
    {
      //~
    }

    public VertexDoesNotExistsException()
      : this("A vertex with this name does not exists in the collection!")
    {
      //~
    }
  }

  public class VertexExistsException : Exception
  {
    public VertexExistsException(string message, Exception causeException)
      : base(message, causeException)
    {
      //~
    }

    public VertexExistsException(string message)
      : this(message, null)
    {
      //~
    }

    public VertexExistsException()
      : this("A vertex with this name already exists in the collection")
    {
      //~
    }
  }
}
