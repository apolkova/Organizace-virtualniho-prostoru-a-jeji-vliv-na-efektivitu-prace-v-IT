using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 10;
        var fibonacci = new FibonacciCalculator();
        int result = fibonacci.CalculateFibonacci(n);

        Console.WriteLine($"The {n}th Fibonacci number is: {result}");
    }
}

class FibonacciCalculator
{
    private readonly Dictionary<int, int> _memo = new Dictionary<int, int>();

    public int CalculateFibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("Index must be non-negative.");

        if (n == 0 || n == 1)

            if (_memo.ContainsKey(n))
                return _memo[n];

        int result = CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        _memo[n] = result;

        return result;
    }
}
