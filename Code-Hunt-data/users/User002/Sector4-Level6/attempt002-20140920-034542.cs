using System;
using System.Linq;
public class Program {
  public static int Fib(int n) {
	  return n<2?1:Fib(n-1)+Fib(n-2);
  }
  public static string Puzzle(string s) {
    return new string(Enumerable.Range(0,s.Length).Select(i=>(char)(97+((int)s[i]-97+Fib(i))%26)).ToArray());
  }
}