using System;

public class Program {
  public static int Puzzle(string s) {
	  int count = 1;
	  if(s == ' ')
	  {
		  return 0;
	  }
	  char[] c = s.ToCharArray();
         for (int i = 0; i < c.Length; i++) {
            if(' ' == c[i]) {
               count++;
            }
        }
        return count;
  }
}