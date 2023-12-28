namespace Algorithms.Sorts;

public class BubbleSort
{
    public void Sort(int[] nums)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    var temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }
    }

}