using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            SortableCollection.LinearSearch(array, 15);

            SortableCollection.BinarySearch(array, 8);

            SortableCollection.Shuffle(array);
        }
    }
}
