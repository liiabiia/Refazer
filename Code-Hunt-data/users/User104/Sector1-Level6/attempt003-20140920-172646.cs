using System;

public class Program {
  public static int Puzzle(string s) {
	 int count=1;
foreach(char x in s)
    if (x==' ') count++;
    return count;
  }
}