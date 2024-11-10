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
        // The starting number is number (a double) and the number of multiple is lenght(an integer)
        // 1. create an empty array of doubles with size same as length
        // 2. create a For loop from 1 to length (e.g if length == 5, then it goes from 1-5)
        // 3. for each iteration, we would multiply the number by the current index and store in the array
        // return the array 

        double[] multiples = new double[length];

        // loop through from 1 to 'length'
        for (int i = 1; i<= length; i++)
        {
            // for each iteration, store the multiple in the array
            multiples[i-1] = number * i;
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
        // 1. check if the amount to rotate is valid
        // use modulus (%) to account for rotations that exceed the list length - amount = amount % data.count
        // split the list into two parts: the first part which contains the last elements 
        // and the second part which contains the first elements
        // join the two parts to form the rotated list
        // modify the original list using the clear method and add the new list back using AddRange

         // Ensure amount is within bounds
        amount = amount % data.Count;

        // Create two sub-lists: one for the last 'amount' elements, and one for the rest
        List<int> rightPart = data.GetRange(data.Count - amount, amount);
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        // Clear the original list and add the rotated parts
        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);


    }
}
