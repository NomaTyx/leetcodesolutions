//leetcode easy. i needed this win tonight, tonight was kinda brutal

using System.Globalization;

string LongestCommonPrefix(string[] strs)
{
    string prefix = "";
    int stringNum = strs.Length;
    int minStringLength = int.MaxValue;

    foreach (string s in strs)
    {
        minStringLength = Math.Min(s.Length, minStringLength);
    }

    for (int i = 0; i < minStringLength; i++)
    {
        for (int j = 0; j < stringNum; j++)
        {
            if (strs[0][i] != strs[j][i])
            {
                return prefix;
            }
        }
        prefix += strs[0][i];
    }

    return prefix;
}