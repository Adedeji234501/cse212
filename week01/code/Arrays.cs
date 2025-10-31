public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. Create a new array of doubles with the given length.
        // 2. Use a loop to fill the array.
        //    Each element at index i should be number * (i + 1).
        // 3. Return the filled array.

        double[] multiples = new double[length];  // Step 1
        for (int i = 0; i < length; i++)          // Step 2
        {
            multiples[i] = number * (i + 1);
        }
        return multiples; 
        
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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. Determine how many items to move: 'amount' items from the end go to the front.
        // 2. Use GetRange to get the last 'amount' items.
        // 3. Use GetRange to get the remaining items at the start.
        // 4. Clear the original list.
        // 5. Add the two ranges back in correct order (last part first, then first part).

        // Step 2: Slice the list into two parts
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Step 4: Clear and rebuild the list
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
