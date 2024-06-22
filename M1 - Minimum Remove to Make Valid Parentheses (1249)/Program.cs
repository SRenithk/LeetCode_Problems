// M1 - Minimum Remove to Make Valid Parentheses (1249) ------------------------------------------------------------
// Code Completed
// Time Taken   : 4 hours
// RunTime      : 79ms
// Memory       : 55.92MB
// Submitted DT : Apr 10, 2024 (23:43)

// Question     : https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/description/
// Submission   : https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/submissions/1228769682/
//------------------------------------------------------------------------------------------------------------------

#region Solution
using System.Text;
using System.Collections;

public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        StringBuilder sb = new StringBuilder();
        Queue queue1 = new Queue();
        Queue queue2 = new Queue();
        int brackets = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                queue1.Enqueue(i);
            }
            else if (s[i] == ')')
            {
                queue2.Enqueue(i);
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                sb.Append(s[i]);
            }
            else if (s[i] == '(' && (queue1.Count > 0 && queue2.Count > 0))
            {
                if (Convert.ToInt32(queue1.Peek()) > Convert.ToInt32(queue2.Peek()))
                {
                    queue2.Dequeue();
                    i--;
                }
                else
                {
                    sb.Append(s[i]);
                    brackets++;
                    queue1.Dequeue();
                    queue2.Dequeue();
                }
            }
            else if (s[i] == ')' && brackets > 0)
            {
                sb.Append(s[i]);
                brackets--;
            }
        }
        Console.WriteLine("\nOutput: " + sb.ToString());
        return sb.ToString();
    }
}
#endregion

#region Main Method
class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();

        #region User Inputs
        Boolean userContinue = false;
        do
        {
            try
            {
                Console.WriteLine("\n\nThis Program will remove round braces that are not properly placed \n" +
                    "\nEx. )))lee(t(c)o)de)))()))()))(( ->  lee(t(c)o)de()() \n" +
                    "\n1. Initial closed braces will be removed" +
                    "\n2. Last Open braces will be removed" +
                    "\n3. Each Open braces needs one closed braces " +
                    "\n4. Open braces will be initially placed followed by closed braces \n\n" +
                    "\nEnter any key to continue");
                Console.ReadLine();

                Console.WriteLine("Sample inputs : \n" +
                    "\n1. lee(t(c)o)de)    -> leet(t(c)o)de" +
                    "\n2. a))))(b(c)d      -> a(bc)d" +
                    "\n3. ))((             -> " +
                    "\n4. (((a)b(c)d(      -> ((a)bc)d" +
                    "\n5. ())()(((         -> ()() \n");

                Console.WriteLine("\n\nEnter custom input with random alphabets & round braces as shown in above example \n");
                var inputs = Console.ReadLine();
                if (inputs != null)
                {
                    s.MinRemoveToMakeValid(inputs.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                Console.WriteLine("\nDo you wish to continue - Press 1 or 2:" +
                    "\n1. Yes, Continue" +
                    "\n2. No, Exit \n\n");

                var cont = Convert.ToInt32(Console.ReadLine());
                if (cont == 1)
                {
                    userContinue = true;
                }
                else
                {
                    userContinue = false;
                }
            }
            catch
            {
                Console.WriteLine("Choose valid option");
            }
        } while (userContinue);

        #endregion
    }
}
#endregion

#region Old Approach
//public class Solution2
//{
//    public string MinRemoveToMakeValid(string s)
//    {
//        var brackets = 0;
//        var position = -1;
//        StringBuilder sb = new StringBuilder();
//        for (int i = 0; i < s.Length; i++)
//        {
//            if (char.IsLetter(s[i]))
//            {
//                sb.Append(s[i]);
//            }
//            else if (s[i] == '(')
//            {
//                for (int j = i + 1; j < s.Length; j++)
//                {
//                    if (s[j] == ')' && position != j)
//                    {
//                        sb.Append(s[i]);
//                        position = j;
//                        brackets++;
//                        break;
//                    }
//                }
//            }
//            else if (s[i] == ')' && brackets > 0)
//            {
//                sb.Append(s[i]);
//                brackets--;
//            }
//        }
//        return sb.ToString();
//    }
//}
#endregion