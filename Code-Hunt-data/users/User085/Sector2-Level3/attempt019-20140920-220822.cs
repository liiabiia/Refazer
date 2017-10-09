using System;

public class Program {
  public static string Puzzle(string s) {
    int i;
	char[] sAux = s.ToCharArray();
	for(i=1; i<s.Length-1; i++)
		sAux[i] = s[s.Length - i];
	string word = new string(sAux);
	return word;
  }
}