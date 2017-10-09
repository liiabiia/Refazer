using System;

public class Program {
  public static string Puzzle(string s) {
    int i;
	char[] sAux;
	for(i=1; i<s.Length-1; i++)
		sAux[i] = s[s.Length - i];
	sAux[0] = s[0];
	sAux[i] = s[i];
	return sAux.ToString();
  }
}