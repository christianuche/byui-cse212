public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> result = new List<int>();
        int index1 = 0;
        int index2 = 0;

        // loop through the selector array
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1 && index1 < list1.Length)
            {
                result.Add(list1[index1]);
                index1++;
            }
            else if (select[i] == 2 && index2 < list2.Length)
            {
                result.Add(list2[index2]);
                index2++;
            }
        }
        return result.ToArray(); // Here instead of an empty list we need to return the result ToArray
    }
}