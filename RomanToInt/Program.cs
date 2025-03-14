//It has been quite a while since i've used a dictionary
//had to spend a while googling the syntax but im sure we're good

Console.WriteLine(RomanToInt("MCMXCIV"));

int RomanToInt(string s)
{
    //dictionary to store roman numeral values instead of using a long line of if statements
    Dictionary<char, int> romanNumeralKey = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    int value = 0;

    //loop through whole string
    for (int i = 0; i < s.Length; i++)
    {
        //minor error trap, at least make sure that the letter is a numeral
        if (romanNumeralKey.ContainsKey(s[i]))
        {
            //add value of the current digit regardless of its value
            value += romanNumeralKey[s[i]];
            if (i < s.Length - 1)
            {
                //this line handles cases like IV or IX. in this case, V is 5 times greater than I and X is 10 times greater.
                //so we just subtract that value twice so that the value ends up being correct
                if (romanNumeralKey[s[i + 1]] > romanNumeralKey[s[i]])
                {
                    value -= romanNumeralKey[s[i]] * 2;

                    //imperative to the program's function
                    if (s[i] == 'C' && s[i + 1] == 'D')
                    {
                        Console.WriteLine("fucking gottem");
                    }
                }
            }

        }
        else
        {
            return -1;
        }
    }

    return value;
}