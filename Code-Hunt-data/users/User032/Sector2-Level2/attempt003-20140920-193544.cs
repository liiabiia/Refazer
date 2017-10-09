using System;
using System.Linq;
public class Program {
  public static int Puzzle(string s) {
	  int x =s.Count((a)=> a=='(');
	  int y=s.Count((a) => a == ')');
    return x == y ? x : 0;
  }
}