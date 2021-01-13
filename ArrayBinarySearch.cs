using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021
{
    public class ArrayBinarySearch
    {
        int lowIndex, highIndex, midIndex;

        public int getArrayMidPoint(int [] refArray)
        {
            lowIndex = 0;
            highIndex = refArray.Length - 1;
            midIndex = (lowIndex + highIndex) / 2;
            return midIndex;
        }
       
    }
}
