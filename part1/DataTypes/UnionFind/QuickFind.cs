using System;

namespace algorithms
{   
    //reference: https://www.cs.princeton.edu/~rs/AlgsDS07/01UnionFind.pdf
    public class QuickFind
    { 
        private int[] _array;

        /*
        for this example:
        0  1__2  3__4
        |     |  |  |
        5__6  7  8  9
        */
        public void Run()
        {
            QuickFind quickFind = new QuickFind(9);
            
            quickFind.Union(4, 3);
            quickFind.Union(3, 8);
            quickFind.Union(9, 4);

            quickFind.Union(6, 5);
            quickFind.Union(5, 0);

            quickFind.Union(7, 2);
            quickFind.Union(2, 1);
            
            Console.WriteLine(quickFind.Find(0, 7));
            //is false
            Console.WriteLine(quickFind.Find(8, 9));
            //is true
            Console.WriteLine(quickFind.Find(6, 2));
            //is false
            Console.WriteLine(quickFind.Find(0, 6));
            //is true
        }
        //Initialize the array: O(n)
        public QuickFind(int size)
        {
            _array = new int[size + 1];

            for (int i = 0; i < size + 1; i++)
            {
                _array[i] = i;
            }
        }

        //Check if two objects are in the same component.
        public bool Find(int a, int b)
        {
            Console.WriteLine("quickFind.Find(" + a + ","+ b +")");
            return _array[a] == _array[b];
        }

        //Replace components containing two objects with their union.
        public void Union(int a, int b)
        {
            int temp = _array[a];

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == temp)
                {
                    _array[i] = _array[b];
                }
            }
        }
        
        //only for check reference from program.cs 
        public string ReturnMessage()
        {
            return "you are in "  + this.GetType().Name + ".cs";
        } 
    }
}