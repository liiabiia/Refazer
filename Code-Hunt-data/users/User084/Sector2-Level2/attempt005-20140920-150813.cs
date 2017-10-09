using System;

public class Program {
  public static int Puzzle(string s) {
	  int nyit = 0;
	  int zar = 0;
	  for (int i=0; i<s.Length; i++) {
		  if (s[i] == '(') nyit++;
		  if (s[i] == ')') zar++;
	  }
	  if (nyit == zar) {
		  return nyit;
	  } else {
		  return 0;
	  }
  }
}