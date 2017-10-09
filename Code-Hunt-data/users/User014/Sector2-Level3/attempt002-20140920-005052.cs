using System;

public class Program {
  public static string Puzzle(string s) {
    if(s.Length<=3)return s;
	int i = 1, j = s.Length-2;
	char[] chrs = s.ToCharArray();
	while(i<j){
		char t = chrs[j];
		chrs[j] = chrs[i];
		chrs[i] = t; 
	}
	return new String(chrs);
  }
}