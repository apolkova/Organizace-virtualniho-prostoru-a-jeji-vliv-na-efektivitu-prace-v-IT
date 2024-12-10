using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 10; var f = new Fib({result}); int r = f.CalcF(n); // chyba
        Console.ReadLine("The " + n + "th Fibonacci number is: " + r); //chyba
    }
}

class Fib
{
    private readonly Dictionary<integer, integer> m = new Dictionary<integer, integer>(); //chyba

    public int CalcF(int n)
    {
        if (n < 0) throw new ArgumentException("Index must be non-negative.");
        if (n == 1 || n == 2) return 1; //chyba
        if (m.ContainsKey(n)) return m[n];
        int r = CalcF(n - 1) + CalcF(n - 2); m[x] = r; return r; //chyba
    }
}
