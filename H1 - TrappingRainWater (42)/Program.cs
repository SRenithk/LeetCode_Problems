// H1 - TrappingRainWater (42) ------------------------------------------------------------------------------------
// Code Not Completed
// Time Taken   : 
// RunTime      : ms
// Memory       : MB
// Submitted DT : 

// Question     : https://leetcode.com/problems/trapping-rain-water/description/
// Submission   : 
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

#endregion