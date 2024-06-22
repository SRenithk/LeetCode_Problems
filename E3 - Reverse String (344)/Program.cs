// E3 - Reverse String (344) --------------------------------------------------------------------------------------
// Code Completed - Not Submitted
// Time Taken   : 
// RunTime      : 
// Memory       : 
// Submitted DT : 

// Question     : https://leetcode.com/problems/reverse-string/description/
// Submission   : 
//------------------------------------------------------------------------------------------------------------------
public class Solution
{
    public char[] ReverseString(char[] s)
    {
        char[] c = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            c[i] = s[s.Length - 1 - i];
        }
        return c;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var op = s.ReverseString(['h', 'e', 'l', 'l', 'o']);
        Console.WriteLine(op);
    }
}