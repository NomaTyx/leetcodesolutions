//i literally stumbled upon this question right after doing IsPalindrome without a string, which required reversing an integer. So I can do that.

Console.WriteLine(Reverse(-2147483648));


int Reverse(int x)
{
    if (x == int.MinValue) return 0;

    int unsignedNum = Math.Abs(x);

    int flippednum = 0;

    while (unsignedNum > 0)
    {
        if (flippednum > int.MaxValue / 10)
        {
            return 0;
        }
        flippednum *= 10;
        flippednum += unsignedNum % 10;
        unsignedNum /= 10;
    }

    if (flippednum == int.MaxValue)
    {
        return 0;
    }

    return x < 0 ? -flippednum : flippednum;
}
