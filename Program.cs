//time complexity of O(n^2) and space complexity is O(1)

int[] nums = { 11, 7, 2, 15 };
int target = 9;

int[] result = TwoSum(nums, target);
Console.WriteLine(string.Join(", ", result));

int[] TwoSum(int[] nums, int target)
{

    int[] indices = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                indices[0] = i;
                indices[1] = j;
            }
        }

    }
    return indices;
}
