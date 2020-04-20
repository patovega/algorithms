using System;

namespace algorithms
{
    public class QuickUnion
    {
        int[] _array;
        int[] _weight;

        //Initialize the array: O(n)
        public QuickUnion(int size)
        {
            _array = new int[size];
            _weight = new int[size];

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = i;
                _weight[i] = 1; //All nodes will have at least size of 1
            }
        }

        //Union with weight: O(log n)
        public void Union(int a, int b)
        {
            int root1 = FindRoot(a);
            int root2 = FindRoot(b);

            if (root1 == root2) { return; }

            if (_weight[root1] < _weight[root2])
            {
                _array[root1] = root2;
                _weight[root2] += _weight[root1];
            }
            else
            {
                _array[root2] = root1;
                _weight[root1] += _weight[root2];
            }
        }

        // Connected: O(log n) same as Union
        // They are connected if their roots are equal
        public bool IsConnected(int a, int b)
        {
            return FindRoot(a) == FindRoot(b);
        }

        //Find the root node with compression 
        int FindRoot(int n)
        {
            int index = n;

            while (_array[index] != index)
            {
                //Make that every node we access points to its grandfather
                _array[index] = _array[_array[index]];
                index = _array[index];
            }

            return index;
        }
        
        //only for check reference from program.cs 
        public string ReturnMessage()
        {
            return "you are in "  + this.GetType().Name + ".cs";
        }
    }
}
