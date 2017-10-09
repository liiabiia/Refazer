using System;

public class Program {
  public static int Puzzle(string s) {
    if (s.Length == 0)
        return 0;

    s = s.Trim();
    while (s.Contains("  "))
        s = s.Replace("  "," ");
	if (s == " ") return 0;
    return s.Split(' ').Length;
  }
}