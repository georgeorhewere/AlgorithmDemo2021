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

        /// <summary>
        /// used to search an intger list for a specific number
        /// </summary>
        /// <param name="itemToFind">number to be searched</param>
        /// <returns>returns 1 if the item is found and -1 if it is not found</returns>

        public int geSearchResult(int itemToFind)
        {
            int result;
            while(low <= high)
            {
                mid = (low + high) / 2;
                result = searchList[mid];

                if (result == itemToFind)
                    return 1;

                if(result < itemToFind)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return - 1;
        }
    }
}
