//Turns out programming on zero sleep is difficult. came back with a fresh head and figured it out.
//just make a dummy array. pretty sure this is still O(m+n) because it's linear

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int[] nums3 = new int[m];
    for (int i = 0; i < m; i++)
    {
        nums3[i] = nums1[i];
    }

    //edge case
    if (m == 0)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[i] = nums2[i];
        }
    }
    //if n == 0 no need to execute anything because num1 will just stay intact
    else if (n > 0)
    {
        int ncounter = 0;
        int mcounter = 0;
        for (int i = 0; i < m + n; i++)
        {
            nums1[i] = 0;
            if (mcounter < m && (ncounter == n || nums3[mcounter] <= nums2[ncounter]))
            {
                nums1[i] = nums3[mcounter];
                mcounter++;
            }
            else if (ncounter < n && (mcounter == m || (nums3[mcounter] > nums2[ncounter])))
            {
                nums1[i] = nums2[ncounter];
                ncounter++;
            }
        }
    }
    //problem directions don't require dealing with m == 0 && n == 0 so i won't :)
}

Merge([4, 0, 0, 0, 0, 0], 1, [1, 2, 3, 5, 6], 5);