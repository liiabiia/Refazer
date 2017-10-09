using System;

public class Program {
  public static int Puzzle(string s) {
	
	int ll = s.Contains("  ") ? 1 : 0;
      
        int pp1 = s.Split(' ').ToArray().Distinct().Count();


        return pp1 - ll;
  }
}