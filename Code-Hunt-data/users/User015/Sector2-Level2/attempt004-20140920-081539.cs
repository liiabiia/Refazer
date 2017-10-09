using System;

public class Program {
  public static int Puzzle(string s) {
    int counter = 0;
            for (int i = 0; i < Math.Truncate(s.Length+0.5) ; i++)
                if (s[i] == '(' && s[s.Length - 1] == ')')
                    counter++;
	return counter;				
  }
}