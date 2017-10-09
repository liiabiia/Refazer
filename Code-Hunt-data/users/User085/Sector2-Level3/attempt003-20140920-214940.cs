using System;

public class Program {
  public static string Puzzle(string s) {
    int i;
	string[] sAux;
	sAux[0] = s[0];
	for(i=i; i<s.Length-1; i++)
		sAux[i] = s[s.Length - i];
	sAux[i] = s[i];
	return sAux;
  }
}