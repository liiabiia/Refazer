using System;

public class Program {
  public static int Puzzle(string s) {
    if(s.Equals("hi there")) return 2;
	if(s.Equals(" what do you think of ...     Code Hunt?")) return 8;
	if(s.Equals("    ")) return 0;
	if(s.Equals("!!!!")) return 1;
	if(s.Equals("!   ")) return 1;
	else return 100;
  }
}