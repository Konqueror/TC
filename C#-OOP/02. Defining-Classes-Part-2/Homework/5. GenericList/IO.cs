using System;
using Lib;

namespace GenericList
{
    class IO
    {
        public static void Main()
        {
        //5 Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
            //Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
            //Implement methods for adding element, accessing element by index, removing element by index, 
            //inserting element at given position, clearing the list, finding element by its value and ToString(). 
            //Check all input parameters to avoid accessing elements at invalid positions.
            GenericList<int> testList = new GenericList<int>(3);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(3);

            //6 Implement auto-grow functionality: when the internal array is full, 
            //create a new array of double size and move all elements to it.
            GenericList<char> growList = new GenericList<char>(2);
            testList.Add('a');
            testList.Add('b');
            testList.Add('c');
            testList.Add('d');
            testList.Add('e');

            //7 Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
            //You may need to add a generic constraints for the type T.
            GenericList<int> comearableList = new GenericList<int>();
            comearableList.Add(1);
            comearableList.Add(4);
            comearableList.Add(1321);
            Console.WriteLine("The biggest element in Comearable List is:");
            Console.WriteLine(comearableList.Max());
        }
    }
}
