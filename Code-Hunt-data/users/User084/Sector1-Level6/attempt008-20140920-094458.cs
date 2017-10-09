using System;

public class Program {
  public static int Puzzle(string s) {
    if (s.Length == 0)
        return 0;

    
    while (s.Contains("  "))
        s = s.Replace("  "," ");
	s = s.Trim();
	//if (s == " ") return 0;
    return s.Split(' ').Length;
  }
}