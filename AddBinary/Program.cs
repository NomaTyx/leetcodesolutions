//There is almost certainly a better way to do this than by converting into int[] but i can't think of it.
//also, it's more practice with arrays, which i desperately do need
//leetcode easy. i had trouble with this one though.
//O(n). i'll take that

string AddBinary(string a, string b)
{
    //variables just for consistency
    string greaterLength = a.Length > b.Length ? a : b;
    string lesserLength = a.Length <= b.Length ? a : b;

    //making an array because adding ints is going to be way easier than adding chars and strings.
    int[] tempArray = new int[greaterLength.Length];

    for (int i = 0; i < greaterLength.Length; i++)
    {
        //characters are stored as their ascii values, and numbers are written in order from 0 to that number. so the ascii value of n will be the value of 0 + n. 
        //therefore, (char)'n' - '0' = (int)n
        tempArray[i] = greaterLength[i] - '0';
    }

    //loop through the array back to front, adding digit by digit (starting at the ones place) until there are none left to add
    for (int i = tempArray.Length - 1; i >= 0; i--)
    {
        if (i >= tempArray.Length - lesserLength.Length)
        {
            //only adding the value if there are digits left to add
            tempArray[i] += lesserLength[i - (tempArray.Length - lesserLength.Length)] - '0';
        }

        //if there's a 2 at the current place, subtract 2 from it, add 1 to the next place value, and try again
        while (tempArray[i] >= 2 && i > 0)
        {
            if (i > 0)
            {
                tempArray[i] -= 2;
                tempArray[i - 1]++;
            }
        }
    }

    //edge case: if the finished string begins with a 2, make a new array that's one longer and then turn 2 into 10
    while (tempArray[0] >= 2)
    {
        int[] newTempArray = new int[tempArray.Length + 1];
        for (int i = 1; i <= tempArray.Length; i++)
        {
            newTempArray[i] = tempArray[i - 1];
        }
        newTempArray[0]++;
        newTempArray[1] -= 2;
        return string.Join("", newTempArray);
    }

    return string.Join("", tempArray);
}

Console.WriteLine(AddBinary("1", "111"));