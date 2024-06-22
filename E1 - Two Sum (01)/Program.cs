// E1 - TwoSum (01) ------------------------------------------------------------------------------------------------
// Code Completed
// Time Taken   : Unknown
// RunTime      : 427ms
// Memory       : 47.83MB
// Submitted DT : Apr 13, 2024 (19:52)

// Question     : https://leetcode.com/problems/two-sum/description/
// Submission   : https://leetcode.com/problems/two-sum/submissions/1231196266/
//------------------------------------------------------------------------------------------------------------------
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        List<int> arr = [];
        int temp = 0;
        int pointer = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            temp += nums[i];
            arr.Add(i);
            if (temp != target && i != pointer)
            {
                temp -= nums[i];
                arr.Remove(i);
            }
            if (temp == target && arr.Count == 2)
            {
                break;
            }

            if (i == nums.Length - 1 && (temp != 0 || target != 0))
            {
                temp = 0;
                arr.Clear();
                pointer++;
                i = pointer - 1;
            }
        }
        return [.. arr]; // means arr.ToArray();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[] input1 = [2, 7, 11, 15];
        int[] input2 = [3, 2, 4];
        int[] input3 = [3, 3];
        int[] input4 = [0, 4, 3, 0];
        int[] input5 = [1, 3, 7, 2, 0, 2, 0];
        int[] input6 = [-3, 4, 3, 90];
        int[] input7 = [2, 7, 11, 15, 6, 45, 23, 6, 1, 0, 0, 0, 2, 6, 8, 2, 100, 100];

        int target1 = 9;
        int target2 = 6;
        int target3 = 6;
        int target4 = 0;
        int target5 = 7;
        int target6 = 0;
        int target7 = 200;

        Solution s = new Solution();
        var op = s.TwoSum(input4, target4);

        Console.WriteLine("[" + string.Join(", ", op) + "]");
    }
}
