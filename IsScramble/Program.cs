//leetcode hard
bool IsScramble(string s1, string s2)
{
    int maxAsciiValue = 0;

    foreach (char c in s1)
    {
        if (c > maxAsciiValue) maxAsciiValue = c + 1;
    }

    int[] s1array = new int[maxAsciiValue];
    int[] s2array = new int[maxAsciiValue];

    foreach (char c in s1)
    {
        s1array[c]++;
    }

    foreach (char c in s2)
    {
        try
        {
            s2array[c]++;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    for (int i = 0; i < s1array.Length; i++)
    {
        if (s1array[i] - s2array[i] != 0)
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine(IsScramble("great", "rreat"));