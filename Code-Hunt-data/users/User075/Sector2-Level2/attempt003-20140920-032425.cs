using System;

public class Program {
  public static int Puzzle(string s) {
    int t1=s.Count(f => f == '(');
	int t2=s.Count(f => f == ')');
	if (t1==t2)
	return t1;
	return 0;
  }
}