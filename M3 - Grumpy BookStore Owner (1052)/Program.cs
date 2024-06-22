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
        var op = 0;
        for (int i = 0; i < customers.Length; i++)
        {
            if (i <= minutes)
            {
                if (grumpy[i] == 0)
                {
                    op = op + customers[i];
                }

            }
            else
            {
                op = op + customers[i];
            }
        }
        return op;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] customers = [3];
        int[] grumpy = [1];
        int minutes = 1;
        var op = s.MaxSatisfied(customers, grumpy, minutes);
        Console.WriteLine(op);

    }
}