namespace HRSolutions.OneWeekPrepare
{
    public static class DiagonalDifferenceProblem
    {
        public static int GetDiagonalDifference(List<List<int>> arr)
        {
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < arr.Count; ++i)
            {
                leftSum += arr[i][i];
                rightSum += arr[i][arr.Count - (i + 1)];
            }

            return Math.Abs(leftSum - rightSum);
        }
    }
}
