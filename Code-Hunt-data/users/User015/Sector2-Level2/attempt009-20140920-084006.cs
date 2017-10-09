using System;

public class Program {
  public static int Puzzle(string s) {
    int counter = 0;
    for (int i = 0; i < Math.Ceiling((double)s.Length / 2); i++)
        if (s[i] == '(' && s[s.Length - 1 - i] == ')')
            counter++;
        else return 0;
	return counter;				
  }
}