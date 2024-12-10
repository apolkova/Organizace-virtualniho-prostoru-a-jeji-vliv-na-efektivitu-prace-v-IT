using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 10; var f = new Fib(); int r = f.CalcF(n);
        Console.WriteLine("The " + n + "th Fibonacci number is: " + r);
    }
}

class Fib
{
    private readonly Dictionary<int, int> m = new Dictionary<int, int>();

    public int CalcF(int n)
    {
        if (n < 0) throw new ArgumentException("Index must be non-negative.");
        if (n == 0 || n == 1) return 1; 
        if (m.ContainsKey(n)) return m[n];
        int r = CalcF(n - 1) + CalcF(n - 2); m[n] = r; return r;
    }
}
