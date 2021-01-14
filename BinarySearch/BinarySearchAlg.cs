using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021.BinarySearch
{
    public class BinarySearchAlg : IBinarySearch<int>
    {
        private int[] searchList;
        private int low, high, mid;
        public BinarySearchAlg(int [] sortedListItems)
        {
            //assumes the array is sorted but we can try  sort it to be sure
            Array.Sort(sortedListItems);
            searchList = sortedListItems;
            low = 0;
            high = sortedListItems.Length - 1;
        }

        public int geSearchResult(int itemToFind)
        {


            throw new NotImplementedException();
        }
    }
}
