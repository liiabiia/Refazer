using System;

public class Program {
  public static int Puzzle(string s) {
	int sum=s.Split(' ').Length;
	foreach(string b in s.Split(' ')){sum-=b==null?1:0;}
	return sum;
  }
}