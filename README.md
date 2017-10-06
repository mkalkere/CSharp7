# CSharp7

C#-7 Features Example

1. local functions
2. pattern matching
3. value tuples


```
class Program
    {


        static int Fibonocci(int n)
        {

            var (r, _) = Fib(n);
            return r;

            (int cur, int prev) Fib(int i)
            {
                if (i == 0) return (1, 0);

                (var c, var p) = Fib(i - 1);
                return (cur: c + p, prev: c);
            }
        }

        static (int cur, int prev) Fib(int i)
        {
            if (i == 0) return (1, 0);

            var (c, p) = Fib(i - 1);
            return (cur: c + p, prev: c);
        }

        static bool TryFibonocci(object o, out int n)
        {
            if (o is int i || o is string s && int.TryParse(s, out i))
            {
                //n = Fib(i).cur;
                (n, _) = Fib(i);
                return true;
            }

            n = 0;
            return false;
        }

        static void Main(string[] args)
        {
            if (TryFibonocci("11", out var r)) Console.WriteLine(r);

            Console.ReadLine();
        }
    }
```
