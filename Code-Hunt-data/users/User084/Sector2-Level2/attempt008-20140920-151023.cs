using System;

public class Program {
  public static int Puzzle(string s) {
	  int nyit = 0;
	  int zar = 0;
	  for (int i=0; i<s.Length; i++) {
		  if (s[i] != '(' && s[i] != ')') return 0;
		  if (s[i] == '(') nyit++;
		  if (s[i] == ')') zar++;
		  if (zar-nyit < 0) return 0;
	  }
	  if (nyit == zar) {
		  return nyit;
	  } else {
		  return 0;
	  }
  }
}