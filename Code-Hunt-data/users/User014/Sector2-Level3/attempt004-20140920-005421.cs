using System;

public class Program {
  public static string Puzzle(string s) {
    if(s.Length<=3)return s;
	int i = 1, j = s.Length-2;
	StringBuilder sb = new StringBuilder(s);
	//char[] chrs = s.ToCharArray();
	while(i<j){
		char t = sb[j];
		sb[j] = sb[i];
		sb[i] = t; 
		++i;--j;
	}
	return sb.ToString();
  }
}