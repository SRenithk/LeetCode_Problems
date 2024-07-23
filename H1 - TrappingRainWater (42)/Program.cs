// H1 - TrappingRainWater (42) ------------------------------------------------------------------------------------
// Code Completed
// Time Taken   : 8 hours (appx)
// RunTime      : 136ms
// Memory       : 44.93MB
// Submitted DT : Jul 23, 2024 (20:11)

// Question     : https://leetcode.com/problems/trapping-rain-water/description/
// Submission   : https://leetcode.com/problems/trapping-rain-water/submissions/1330754071/
//------------------------------------------------------------------------------------------------------------------

#region OldApproach_Still_Incorrect
//// 02 - TrappingRainWater
//// Own Logic    : Code Completed
//// Time Taken   : 45 Minutes
//// RunTime      : 
//// Memory       :
//
//class Solution
//{
//    public static int Trap(int[] height)
//    {
//        int collectedWater = 0;
//        for (int i = 0; i < height.Length; i++)
//        {
//            if (height[i] != 0)
//            {
//                int trapedWater = 0;
//                for (int j = i + 1; j < height.Length; j++)
//                {
//                    if (height[j] >= height[i])
//                    {
//                        collectedWater += trapedWater;
//                        i = j - 1;
//                        break;
//                    }
//                    else if (height[j] < height[i])
//                    {
//                        trapedWater += (height[i] - height[j]);
//                    }
//                }
//            }
//        }
//        return collectedWater;
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Input : [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1] \n\n" +
//            "            []       \n" +
//            "     []2 3 4[][]6 []  \n" +
//            " _[]1[][]5[][][][][][]\n");

//        int[] input1 = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
//        int[] input2 = [4, 2, 0, 3, 2, 5];
//        int[] input3 = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
//        int[] input4 = [4, 2, 3];

//        Console.WriteLine("Output: " + Solution.Trap(input4));
//    }
//}

//// [ 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]
////
////  
////
////            []       
////     []2 3 4[][]6 []  
//// _[]1[][]5[][][][][][]
#endregion

#region NewApproach
class Solution
{
    public static int Trap(int[] height)
    {
        int collectedWater = 0;
        int trapWater = 0;
        int flag = 0;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i + 1; j < height.Length; j++)
            {
                flag = 0;
                if (height[j] >= height[i])
                {
                    collectedWater += trapWater;
                    trapWater = 0;
                    i = j;
                    flag = 1;
                }
                else
                {
                    trapWater = trapWater + (height[i] - height[j]);
                }
            }
            trapWater = 0;
            if (flag == 0 && height[i] > 0)
            {
                height[i]--;
                i--;
            }
            flag = 0;
        }
        return collectedWater;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[] input1 = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]; // 6
        int[] input2 = [0, 4, 3, 2, 4, 1, 0]; // 3
        int[] input3 = [4, 2, 3]; // 1
        int[] input4 = [0, 1, 5, 2, 5, 6, 3, 3, 2, 0, 6, 0, 2, 6, 5]; // 29
        int[] input5 = [0, 4, 3, 2, 4, 1, 2, 3, 0, 1]; // 7
        int[] input6 = [0]; // 0

        var op = Solution.Trap(input6);
        Console.WriteLine(op);
    }
}

#endregion