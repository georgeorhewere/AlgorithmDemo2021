using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021.ListAlg
{
    public class NeighbourTests
    {




        public List<string> printNeighbourNodes(char[,] nodegGrid)
        {
            List<string> resultList = new List<string>();

            // get grid dimensions
            int rows = nodegGrid.GetLength(0);
            int cols = nodegGrid.GetLength(1);
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if(nodegGrid[row, col].Equals('0'))
                    {
                        //find neighbour nodes
                        //right 
                        bool hasBottomNode = (col + 1) < cols;
                        //bool hasRightNode = (col + 1) < cols;
                        string bottomNodeState = "";
                        //string rightNodeState = "";
                        if (hasBottomNode)
                        {
                            bottomNodeState = nodegGrid.GetValue(row, col + 1).Equals('0') ? $"{ row} {col + 1}" : "-1 -1";
                        }
                        else
                        {
                            bottomNodeState = "-1 -1";
                        }
                        //bottom
                        bool hasRightNode = (row + 1) < rows;
                        string rightNodeState = "";
                        if (hasRightNode)
                        {
                            rightNodeState = nodegGrid.GetValue(row +1, col).Equals('0') ? $"{ row + 1} {col}" : "-1 -1";
                        }
                        else
                        {
                            rightNodeState = "-1 -1";
                        }



                        resultList.Add($" value { nodegGrid[row, col] }  node { row} {col} {rightNodeState } {bottomNodeState} ");
                    }                   
                }
            }





            return resultList;
        }


    }
}
