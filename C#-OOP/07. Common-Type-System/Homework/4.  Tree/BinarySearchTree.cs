using System;

namespace _4.Tree
{
    public class  BinarySearchTree<T> where T : IComparable
    {
        private TreeNode<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        // http://en.wikipedia.org/wiki/Binary_search_tree algorithm from wikipedia
        private void FindPlaceAndInsert(TreeNode<T> parent, TreeNode<T> child)
        {
            if (child.CompareTo(parent) == -1)
            {
                if (parent.LeftNode == null)
                    parent.LeftNode = child;
                else
                    FindPlaceAndInsert(parent.LeftNode, child);

            }
            else 
            {
                if (parent.RightNode == null)
                    parent.RightNode = child;
                else
                    FindPlaceAndInsert(parent.RightNode, child);
            }
        }

        public void AddElement(TreeNode<T> newNode)
        {
            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                FindPlaceAndInsert(root, newNode);
            }
        }

        public void DeleteElement(T value)
        {
            //TODO: delete all Nodes under the deleted one and make the GC delete it. It is not a OOP thing so do it later.
        }

        public TreeNode<T> SeachElement(T value)
        {
            return root.SeachElement(value);
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
}
