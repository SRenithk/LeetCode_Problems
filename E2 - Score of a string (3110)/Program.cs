// E2 - Score of a string (3110) -----------------------------------------------------------------------------------
// Code Completed
// Time Taken   : 30 minutes
// RunTime      : 43ms
// Memory       : 39.15MB
// Submitted DT : Jun 14, 2024 (22:21)

// Question     : https://leetcode.com/problems/score-of-a-string/description/
// Submission   : https://leetcode.com/problems/score-of-a-string/submissions/1288316777/
//------------------------------------------------------------------------------------------------------------------
using System.Collections;

public class Solution 
{
    public int ScoreOfString(string s)
    {
        ArrayList array = new();
        var total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var ascii = Convert.ToInt32(s[i]);
            array.Add(ascii);
        }
        for (int j = 0; j < s.Length - 1; j++)
        {
            var sum = Convert.ToInt32(array[j]) - Convert.ToInt32(array[j + 1]);
            sum = sum < 0 ? sum * -1 : sum; //Remove negative number
            total += sum;
        }
        return total;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine("Enter a Name");
        var input = Console.ReadLine();
        var op = s.ScoreOfString(input);
        Console.WriteLine(op); 
    }
}