// E5 - Palindrome Number (9) --------------------------------------------------------------------------------------
// Code Completed 
// Time Taken   : 30 minutes (with string conversion) ; 25 minutes ( without string conversion) ;
// RunTime      : 2ms
// Memory       : 32.36MB - used long (to validate long numbers)
// Submitted DT : Dec 21, 2024 22:52

// Question     : https://leetcode.com/problems/palindrome-number/description/
// Submission   : https://leetcode.com/problems/palindrome-number/submissions/1484771345/
//------------------------------------------------------------------------------------------------------------------

public class Solution
{
    // Challenge - Without converting to String 
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        long ip = x;
        long final = 0;
        while (ip > 0)
        {
            long check = ip / 10;
            long mod = ip % 10;
            if (ip > 0)
            {
                ip = check;
                final = (mod * 10) + (10 * final);
            }
        }
        return final / 10 == x ? true : false;


        ////With converting to string
        //string panlindrome = x.ToString();
        //int left = 0;
        //int right = panlindrome.Length - 1;

        //while (left < right)
        //{
        //    if (panlindrome[left] != panlindrome[right]) return false;
        //    left++;
        //    right--;
        //}
        //return true;
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Solution s = new();
            int input1 = 101;
            int input2 = -121;
            int input3 = 1001;
            int input4 = 1000000001;
            Console.WriteLine(s.IsPalindrome(input4));
        }
    }
}