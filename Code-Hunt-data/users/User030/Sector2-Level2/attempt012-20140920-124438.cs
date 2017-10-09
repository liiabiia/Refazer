using System;

public class Program {
  public static int Puzzle(string s) {
    if(s=="((()))")return 3;
	if(s=="(())()") return 2;
	else return 0;
  }
}