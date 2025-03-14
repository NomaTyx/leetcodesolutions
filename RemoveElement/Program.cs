//leetcode easy. roughly 20
int RemoveElement(int[] nums, int val)
{

    if (nums.Length == 0 || (nums.Length == 1 && nums[0] != val))
    {
        return nums.Length;
    }

    //j is the spot of the last value that isn't val
    //i is the spot in the list we're looking at
    int j = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        //replacing spot j with spot i if spot i was not val.
        //that means that in the list [2, 2, 1, 4, 5, 6] where val is 2
        // when i is 0 or 1, j stays at 0. when i is 2, nums[i] is 1 (not val) 
        //which means nums[j] gets set equal to nums[i].
        if (nums[i] != val)
        {
            nums[j] = nums[i];
            j++;
        }
    }
    return j;
}

Console.WriteLine(RemoveElement([2, 2, 1, 4, 5, 6], 2));