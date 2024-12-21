// H2 - Candy (135) ------------------------------------------------------------------------------------------------
// Code Not Completed
// Time Taken   : 
// RunTime      : 
// Memory       : 
// Submitted DT : 

// Question     : https://leetcode.com/problems/candy/description/
// Submission   : 
//------------------------------------------------------------------------------------------------------------------
public class Solution
{
    public int Candy(int[] ratings)
    {
        int pointer = 0;
        int result = 1;
        for (int i = 0; i < ratings.Length; i++)
        {
            int candy = 0;
            pointer = i;
            if((i+1) > ratings.Length-1)
            break;
            if (ratings[i] < ratings[i + 1])
            {
                candy = result + 1;
                result = result + candy;
            }
            else if(ratings[i] > ratings[i + 1])
            {
                if(i + 1 < ratings.Length)
                {
                    while (ratings[i] > ratings[i + 1])
                    {
                        result++;
                        i--;
                        if(i<0)
                        break;
                    }
                }
                i = pointer;
            }
            else
            {
                result++;
            }

        }
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] input1 = [1, 0, 2]; // 2, 1, 2 = 5
        int[] input2 = [1, 2, 2]; // 1, 2, 1 = 4
        int[] input3 = [100, 80, 70, 60, 70, 80, 90, 100, 90, 80, 70, 60, 60];
        int[] input4 = [6, 7, 6, 5, 4, 3, 2, 1, 0, 0, 0, 1, 0];
        int[] input5 = [20000, 20000, 16001, 16001, 16002, 16002, 16003, 16003, 16004, 16004, 16005, 16005, 16006, 16006, 16007, 16007, 16008, 16008, 16009, 16009, 16010, 16010, 16011, 16011, 16012, 16012, 16013, 16013, 16014, 16014, 16015, 16015, 16016, 16016, 16017, 16017, 16018, 16018, 16019, 16019, 16020, 16020, 16021, 16021, 16022, 16022, 16023, 16023, 16024, 16024];
        var op = s.Candy(input2);
        Console.WriteLine(op);
    }
}
