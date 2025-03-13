//not the most proud of this one. ugh. tired. also i use lists more than arrays so definitely something to work on in the future.

int RemoveDuplicates(int[] nums)
{
    int k = nums.Length;
    int temp;

    for (int i = 0; i < k - 1; i++)
    {
        if (k == 1) return k;
        if (nums[i] == nums[i + 1])
        {
            for (int j = i; j < nums.Length - 1; j++)
            {
                temp = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = temp;
            }

            k--;
            i--;
        }
    }
    return k;
}
Console.WriteLine(RemoveDuplicates([1, 2, 3, 4, 5, 6]));