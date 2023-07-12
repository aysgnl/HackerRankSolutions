using HRSolutions.OneWeekPrepare;

#region LonelyIntegerProblem
List<int> a = new() { 1, 2, 3, 4, 3, 2, 1 };
int resultLonelyInteger = LonelyIntegerProblem.GetLonelyinteger(a);
#endregion

#region DiagonalDifferenceProblem
int n = Convert.ToInt32(Console.ReadLine().Trim());
List<List<int>> arr = new List<List<int>>();
for (int i = 0; i < n; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

int resultDiagonalDifference = DiagonalDifferenceProblem.GetDiagonalDifference(arr);
#endregion

#region CountingSortProblem
int nCountingSortProblem = Convert.ToInt32(Console.ReadLine().Trim());
List<int> arrCountingSortProblem = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
List<int> resultCountingSortProblem = CountingSortProblem.GetCountingSort(arrCountingSortProblem);
#endregion

#region CountingSortProblem
int q = Convert.ToInt32(Console.ReadLine().Trim());
for (int qItr = 0; qItr < q; qItr++)
{
    int nflippingMatrixProblem = Convert.ToInt32(Console.ReadLine().Trim());

    List<List<int>> matrix = new List<List<int>>();

    for (int i = 0; i < 2 * n; i++)
    {
        matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
    }

    int flippingMatrixProblem = FlippingMatrixProblem.GetFlippingMatrix(matrix);   
}
#endregion

Console.WriteLine(resultCountingSortProblem);
