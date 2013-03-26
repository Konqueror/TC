// 4. Define the data structure binary search tree with operations for "adding new element", "searching element"
// and "deleting elements". It is not necessary to keep the tree balanced. Implement the standard methods from 
// System.Object – ToString(), Equals(…), GetHashCode() and the operators for comparison  == and !=. Add and 
// implement the ICloneable interface for deep copy of the tree. Remark: Use two types – structure 
// BinarySearchTree (for the tree) and class TreeNode (for the tree elements). Implement IEnumerable<T> to 
// traverse the tree.
using System;

namespace _4.Tree
{
    class IO
    {
        static void Main()
        {
            BinarySearchTree<int> newTree = new BinarySearchTree<int>();

            newTree.AddElement(new TreeNode<int>(16));
            newTree.AddElement(new TreeNode<int>(8));
            newTree.AddElement(new TreeNode<int>(32));
            newTree.AddElement(new TreeNode<int>(4));
            newTree.AddElement(new TreeNode<int>(64));
            newTree.AddElement(new TreeNode<int>(128));
            newTree.AddElement(new TreeNode<int>(256));
            newTree.AddElement(new TreeNode<int>(512));

            Console.WriteLine(newTree); // Recursive display all nodes of the tree
            Console.WriteLine("Serach element 512: ");
            newTree.SeachElement(512).LeftNode = null;
            
            //TODO: Implement 
        }
    }
}
