using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021.BinarySearch
{
    public interface IBinarySearch<T>
    {
        T geSearchResult(T itemToFind);
    }
}
