using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021.StringSearch
{
    public interface IStringSearchAlg
    {
        IEnumerable<StringAlgMatch> FindStringMatches(string toFind, string toSearch);
    }

    public class StringAlgMatch
    {
        public int StartIndex { get; set; }
        public int MatchLength { get; set; }
    }
}
