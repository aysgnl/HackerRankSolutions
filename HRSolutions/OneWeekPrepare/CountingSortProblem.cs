using System;

namespace HRSolutions.OneWeekPrepare
{
    public static class CountingSortProblem
    {
        public static List<int> GetCountingSort(List<int> arr)
        {
            int[] result = new int[100];
            for (int i = 0; i < arr.Count; i += 100)
            {
                for (int j = i; j < i + 100; j++)
                    result[arr[j]]++;
            }
            return result.ToList();
        }
    }
}
