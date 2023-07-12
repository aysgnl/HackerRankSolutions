namespace HRSolutions.OneWeekPrepare
{
    public static class LonelyIntegerProblem
    {
        public static int GetLonelyinteger(List<int> a)
        {
            var lonelyHashSet = new HashSet<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (lonelyHashSet.Contains(a[i]))
                    lonelyHashSet.Remove(a[i]);
                else
                    lonelyHashSet.Add(a[i]);
            }

            return lonelyHashSet.FirstOrDefault();
        }
    }
}
