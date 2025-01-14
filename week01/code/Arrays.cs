public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double numbers, int length)
    {
        // TODO Problem 1 Start
        // step 1: Firstly we need an array that will hold the multiples, with size equal to "Length"
        double[]multiples = new double[length];

        // step 2: We need to Loop through "Length" times to get a calculation of each multiple, we are going to use a "for" Loop for that
        for (int i = 0; i < length; i++)
        {
            // In this step 3: We will calculate the multiple by multiplying "number" by (i + 1)
            multiples[i] = numbers * (i + 1);
        }
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // step 4: Returns the array of multiples
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Step 1: Here we would use modulus to handle cases where amount > data.Count 
        amount = amount % data.Count;

        // Step 2: Determine the split index
        int splitIndex = data.Count - amount;

        // Step 3: Create two parts of the List
        List<int> secondPart = data.GetRange(splitIndex, amount);
        List<int> firstPart = data.GetRange(0, splitIndex);

        // Step 4: Clear the original list and add the parts in the correct order
        data.Clear();
        data.AddRange(secondPart);
        data.AddRange(firstPart);
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
