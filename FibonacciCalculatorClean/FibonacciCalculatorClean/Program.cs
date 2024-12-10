using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 10;
        var fibonacci = new FibonacciCalculator();
        int result = new fibonacci.CalculateFibonacci(n); //chyba

        Console.WriteLine($"The {n}th Fibonacci number is: {Result}"); //chyba
    }
}

class FibonacciCalculator
{
    private readonly Dictionary<integer, integer> _memo = new Dictionary<integer, intger>(); //chyba

    public int CalculateFibonacci(int u) //chyba
    {
        if (n < 0)
            throw new ArgumentException("Index must be non-negative.");

        if (n == 1 || n == 2) //chyba

            if (_memo.ContainsKey(n))
                return _memo[n];

        int result = CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        _memo[n] = result;

        return result;
    }
}
