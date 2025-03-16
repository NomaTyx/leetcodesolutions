//easiest leetcode problem so far

int LengthOfLastWord(string s)
{
    s = s.Trim();
    int chars = 0;

    foreach (char c in s)
    {
        if (c == ' ')
        {
            chars = 0;
        }
        else
        {
            chars++;
        }
    }

    return chars;
}

Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));