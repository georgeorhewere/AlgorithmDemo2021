using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021.StringSearch
{
    public class BMYStringSearch : IStringSearchAlg
    {
        public IEnumerable<StringAlgMatch> FindStringMatches(string toFind, string toSearch)
        {
            var matchTable = new BadMatch(toFind);

            // matchTable.printTable();
            var pattern = toFind;
            
            int currentStartIndex = 0;

            while(currentStartIndex <= (toSearch.Length - pattern.Length))
            {

                int charactersLeftToMatch = toFind.Length - 1;

                while(charactersLeftToMatch >= 0 && toFind[charactersLeftToMatch] == toSearch[currentStartIndex + charactersLeftToMatch])
                {
                    charactersLeftToMatch--;
                }

                if(charactersLeftToMatch < 0)
                {                    
                    yield return new StringAlgMatch { StartIndex = currentStartIndex, MatchLength = toFind.Length };
                    currentStartIndex += toFind.Length;
                }
                else
                {
                    string shiftItem = toSearch[currentStartIndex + (toFind.Length - 1)].ToString();
                    currentStartIndex += matchTable.getShiftSize(shiftItem);
                }
                
                    
            }            
           
        }
    }

    internal class BadMatch
    {
        public Dictionary<string, int> BadMatchTable;
        public int DefaultSkip { get; set; }
        public BadMatch(string toFind)
        {
            BadMatchTable = new Dictionary<string, int>();
            DefaultSkip = toFind.Length;
            for(int x=0; x < DefaultSkip -1; x++)
            {
                BadMatchTable[toFind[x].ToString()] = DefaultSkip - x -1;
            }
        }

        public void printTable()
        {
            foreach(var item in BadMatchTable)
            {
                Console.WriteLine($"Key {item.Key } Value { item.Value }");
            }
        }

        public int getShiftSize(string val)
        {
            if (BadMatchTable.ContainsKey(val))
            {
                return BadMatchTable[val];
            }
            else
            {
                return DefaultSkip;
            }

        }

    }
}
