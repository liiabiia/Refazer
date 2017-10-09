using System;

public class Program {
  public static int Puzzle(string s) {
	int sum=s.Split(' ').Length;
	foreach(string b in s.Split(' ')){b==null?sum--:sum;}
	return sum;
  }
}