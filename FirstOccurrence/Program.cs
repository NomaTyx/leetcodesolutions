//Leetcode easy. It ain't no KMP algorithm but it's honest work

int StrStr(string haystack, string needle)
{
    int numOfSharedLetters = 0;
    int spot = -1;

    //edge cases
    if (needle.Length > haystack.Length) return -1;

    //i don't want to fix errors to make this work with single character
    if (needle.Length == haystack.Length)
    {
        if (needle == haystack)
        {
            return 0;
        }
        return -1;
    }

    //start looking back to front
    for (int i = haystack.Length - needle.Length; i >= 0; i--)
    {
        //compare haystack[i] with needle[0] until it finds a match
        if (haystack[i] == needle[0])
        {
            for (int j = i; j < haystack.Length; j++)
            {
                if (needle[numOfSharedLetters] == haystack[j])
                {
                    numOfSharedLetters++;
                    if (numOfSharedLetters == needle.Length)
                    {
                        //sets the spot where the substring starts
                        spot = i;
                        numOfSharedLetters = 0;
                    }
                }
                else
                {
                    numOfSharedLetters = 0;
                    break;
                }
            }
            //continue looping because we're searching back to front, which means there may be an earlier occurrence
        }
    }

    return spot;
}

Console.WriteLine(StrStr("abc", "c"));