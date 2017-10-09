using System;

public class Program {
  public static int Puzzle(string s) {
	  int count = 0;
	  char[] c = s.ToCharArray();
        for(int i = c.length() - 1; i >= 0; i--) {
            if(' ' == c) {
               count++;
            }
        }
        return count;
  }
}