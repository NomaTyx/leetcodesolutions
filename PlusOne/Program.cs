//This definitely isn't the most efficient solution. I don't know if creating another array is necessary and

int[] PlusOne(int[] digits)
{
    //if all digits are 9s, we'll need more space for the incoming place value
    bool all9s = true;
    foreach (int i in digits)
    {
        if (i != 9) all9s = false;
    }
    int[] newDigits = new int[all9s ? digits.Length + 1 : digits.Length];
    int counter = 0;

    if (newDigits.Length > digits.Length)
    {
        counter++;
    }

    foreach (int j in digits)
    {
        newDigits[counter] = j;
        counter++;
    }

    Console.WriteLine(string.Join(" ", newDigits));

    newDigits[newDigits.Length - 1]++;

    for (int i = newDigits.Length - 1; i > 0; i--)
    {
        if (newDigits[i] == 10)
        {
            newDigits[i] = 0;
            newDigits[i - 1]++;
        }
    }

    return newDigits;
}

Console.WriteLine(string.Join(" ", PlusOne([4, 5, 9, 9, 9])));