//this solution is less about optimization and more about using things that
//i haven't used much. just for practice. also because stacks and foreaches are fun, i think

bool IsPalindrome(string s)
{
    s = s.Trim().ToLower();
    Stack<char> chars = new Stack<char>();
    int sAlphaNumericLength = 0;

    foreach (char c in s)
    {
        if (char.IsLetterOrDigit(c)) sAlphaNumericLength++;
    }

    foreach (char c in s[0..(sAlphaNumericLength / 2)])
    {
        if (char.IsLetterOrDigit(c)) chars.Push(c);
    }

    Console.WriteLine(string.Join("", chars));

    foreach (char c in s[^(s.Length / 2)..s.Length])
    {
        if (!char.IsLetterOrDigit(c)) continue;

        if (chars.TryPop(out char result))
        {
            if (result != c)
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine(IsPalindrome(",hi"));