using System;

public class Program {
  public static string Puzzle(string s)
        {
            var result = String.Empty;
            int n = 0;
            foreach (var c in s)
            {
                var i = (c - 97 + Fib(n)) % 26;
                result += (char)(i + 97);
                n++;
            }


            return result;
        }


        public static int Fib(int n)
        {
            if (n < 2) return 1;
            return Fib(n - 2) + Fib(n - 1);
        }
}