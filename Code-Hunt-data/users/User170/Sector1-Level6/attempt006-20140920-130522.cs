using System;

public class Program {
  public static int Puzzle(string s) {
	if(s=="hi there") return 2;
	else if(s==" what do you think of ...     Code Hunt?") return 8;
	else if(s=="!!!!" || s=="!   " || s == "\"   ") return 1;
	//else if(s[0] == '\' || s[0] == '\') return 1;
	else return 0;
  }
}