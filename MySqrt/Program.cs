int MySqrt(int x)
{
    //46341 is sqrt(max_value)
    int min = 0, max = 46341;
    int mid = min + max / 2;

    do
    {
        if (mid * mid < x)
        {
            min = mid;
        }
        else if (mid * mid > x)
        {
            max = mid;
        }
        else
        {
            return mid;
        }

        //note to self when writing binary searches: this goes on the bottom and not on the top!!
        mid = (min + max) / 2;
    } while (mid > min && mid < max);

    return mid;
}


Console.WriteLine(MySqrt(2));