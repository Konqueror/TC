using System;
using System.Linq;
using System.Text;

namespace _4.Tree
{

    public class TreeNode<T> where T : IComparable
    {
        public T value;
        private TreeNode<T> leftNode;
        private TreeNode<T> rightNode;

        public TreeNode<T> LeftNode
        {
            get
            {
                return this.leftNode;
            }
            set
            {
                this.leftNode = value;
            }
        }

        public TreeNode<T> RightNode
        {
            get
            {
                return this.rightNode;
            }
            set
            {
                this.rightNode = value;
            }
        }

        // Constructors:
        public TreeNode(T value)
            : this(value, null, null)
        {
        }

        public TreeNode(T value, TreeNode<T> node)
            : this(value, node, null)
        {
        }

        public TreeNode(T value, TreeNode<T> leftNode, TreeNode<T> rightNode)
        {
            this.value = value;
            this.leftNode = leftNode;
            this.rightNode = rightNode;
        }

        public int CompareTo(TreeNode<T> otherObject)
        {
            return value.CompareTo(otherObject.value);
        }

        public override string ToString()
        {
            return StringHellper(0);
        }

        private string StringHellper(int level)
        {
            StringBuilder result = new StringBuilder();

            result.Append(value);

            if (LeftNode != null)
            {
                result.Append("\n  ");
                result.Append('>', level);
                result.Append(LeftNode.StringHellper(level + 4));
            }

            if (RightNode != null)
            {
                result.Append("\n  ");
                result.Append('>', level);
                result.Append(RightNode.StringHellper(level + 4));
            }

            return result.ToString();
        }

        public TreeNode<T> SeachElement(T value)
        {
            if (value.CompareTo(this.value) == 0)
            {
                return this;
            }
            else if (value.CompareTo(this.value) == -1)
            {
                if (this.LeftNode == null)
                    throw new Exception("Element not found");
                else
                    return this.LeftNode.SeachElement(value);

            }
            else
            {
                if (this.RightNode == null)
                    throw new Exception();
                else
                    return this.RightNode.SeachElement(value);
            }
        }

    }

}
