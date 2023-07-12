using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSolutions.OneWeekPrepare
{
    public static class FlippingMatrixProblem
    {
        public static int GetFlippingMatrix(List<List<int>> matrix)
        {
            int n = matrix.Count / 2;
            int[] newArray = new int[4];
            List<int> result = new List<int>();

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    newArray[0] = matrix[x][y];
                    newArray[1] = matrix[2 * n - 1 - x][y];
                    newArray[2] = matrix[x][2 * n - 1 - y];
                    newArray[3] = matrix[2 * n - 1 - x][2 * n - 1 - y];

                    result.Add(newArray.Max());
                }
            }
            return result.Sum();
        }
    }
}
