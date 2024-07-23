// M3 - Grumpy BookStore Owner (1052) ------------------------------------------------------------------------------
// Code Not Completed
// Time Taken   : 
// RunTime      : 
// Memory       : 
// Submitted DT : 

// Question     : https://leetcode.com/problems/grumpy-bookstore-owner/description/
// Submission   : 
//------------------------------------------------------------------------------------------------------------------
public class Solution // Attempted - Not Solved
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        var sum = 0;
        for (int i = 0; i < customers.Length; i++)
        {
            if (i >= minutes && customers[i] > 0 && grumpy[i] > 0) //Ignore logic
            {
                continue;
            } else
            {
                sum += customers[i];
            }
        }
        return sum;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] customers = [1, 0, 1, 2, 1, 1, 7, 5];
        int[] grumpy =    [0, 1, 0, 1, 0, 1, 0, 1];
        int minutes = 3;
        var op = s.MaxSatisfied(customers, grumpy, minutes);
        Console.WriteLine(op);

    }
}