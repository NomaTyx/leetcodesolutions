//this is just a binary search. leetcode easy
int SearchInsert(int[] nums, int target)
{
    int min = 0;
    int max = nums.Length;
    int mid = max / 2;

    do
    {
        if (target > nums[mid])
        {
            min = mid;
        }
        else if (target < nums[mid])
        {
            max = mid;
        }
        else
        {
            return mid;
        }

        //note to self when writing binary searches: this goes on the bottom and not on the top!!
        mid = (min + max) / 2;
    } while (mid > min && mid < max);

    if (mid < nums.Length && target > nums[mid])
    {
        mid++;
    }

    return mid;
}

Console.WriteLine(SearchInsert([1, 2], 1));