using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021.StringSearch
{
    public class NaiveSearchAlg : IStringSearchAlg
    {
        public IEnumerable<StringAlgMatch> FindStringMatches(string toFind, string toSearch)
        {
            int startIndex = 0;
            int matchCount = 0;
            for (startIndex = 0; startIndex < toSearch.Length-1; startIndex++)
            {
                matchCount = 0;
                while (toSearch[matchCount + startIndex] == toFind[matchCount])
                {
                    matchCount++;
                    if (toFind.Length == matchCount)
                    {                        
                        yield return new StringAlgMatch { StartIndex = startIndex, MatchLength = matchCount };
                        matchCount--;
                        break;
                    }
                }



            }
        }
    }
}
