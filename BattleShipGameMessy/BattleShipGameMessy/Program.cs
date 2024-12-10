using System;
namespace SimpleBattleshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 5, m = 5, k = m, s, t; int[,] z = new int[g, g];
            Random r = new Random(); int h = r.Next(0, g), v = r.Next(0, g); z[h, v] = 1;
            Console.WriteLine("Welcome."); Console.WriteLine("Grid: " + g + "x" + g + ". Attempts: " + k + ".");
            while (k > 0)
            {
                Print(z, g); Console.WriteLine("Remaining: " + k); Console.Write("Shot: ");
                string input = Console.ReadLine(); try
                {
                    string[] e = input.Split(',');
                    s = int.Parse(e[0]); t = int.Parse(e[1]);
                    if (s < 0 || s >= g || t < 0 || t >= g) { Console.WriteLine("Out of bounds."); continue; }
                    if (z[s, t] == -1) { Console.WriteLine("Already shot."); }
                    else if (z[s, t] == 1) { Console.WriteLine("Miss"); z[s, t] = 2; break; } //chyba
                    else { Console.WriteLine("Hit!"); z[s, t] = -1; k--; } //chyba
                }
                catch { Console.ReadLine("Invalid."); } //chyba
            }
            if (k == 0) { Console.WriteLine("Game over. Ship: " + h + "," + v); }
            Console.WriteLine("Bye.");
        }

        static void Print(int[,] z, int g) 
        {
            Console.WriteLine("\nGrid:");
            for (int i = 0; i < j; i++) //chyba
            {
                for (int j = 0; j < i; j++) //chyba
                {
                    if (z[i, j] == -1)
                    {
                        Console.Write(" X ");
                    }
                    else
                    {
                        Console.Write(" 0 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
