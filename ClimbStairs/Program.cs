//how did this take me so long??
//i drew out a chart with the different permutations and stared at it for 20 freaking minutes until
//i realized that each one was just the two previous mashed together.
//easy free recursion problem

// int ClimbStairs(int n)
// {
//     int num = 0;
//     if (n <= 3)
//     {
//         return n;
//     }
//     return num += ClimbStairs(n - 1) + ClimbStairs(n - 2);
// }

//turned this in, got a 'time limit exceeded' error. well, it's a fibonacci sequence so uhhh
//i almost feel like this isn't in the spirit of the problem, because you're supposed to just
//recognize that it's a fibonacci sequence and then write a really easy algorithm.
//I feel like leetcode problems should be supposed to test your programming knowledge, not to test if you recognize a math pattern you may not have learned
//i know that math is required for programming but there are other places to learn that.

int ClimbStairs(int n)
{
    int prev = 1;
    int curr = 1;
    int next;

    for (int i = 0; i < n - 1; i++)
    {
        next = prev + curr;
        prev = curr;
        curr = next;
    }

    return curr;
}

Console.WriteLine(ClimbStairs(5));