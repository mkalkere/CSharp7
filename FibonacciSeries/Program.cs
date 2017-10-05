using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{

    class Program
    {



        static int Fibonocci(int n)
        {
            (var r, _) = Fib(n);
            return r;

            (int curr, int prev) Fib(int i)
            {
                if (i == 0)
                    return (1, 0);

                (int c, int p) = Fib(i - 1);
                return (curr: c + p, prev: c);

            }
        }

        static (int cur, int prv) Fib(int n)
        {
            if (n == 0)
                return (1, 0);

            (var c, var p) = Fib(n - 1);
            return (cur: c + p, prv: c);
        }

        static bool TryFibonocci(object o, out int r)
        {
            if (o is int n || o is string s && int.TryParse(s, out n))
            {
                (r, _) = Fib(n);
                return true;
            }

            r = 0;
            return false;
        }

        static void Main(string[] args)
        {
            if (TryFibonocci("11", out var r)) Console.WriteLine(r);
        }
    }
}
