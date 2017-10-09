using System;

public class Program {
  public static string Puzzle(string s) {
	  if(s.Length%2 == 1) return s;
	  char temp;
	  char [] ns = s.ToArray();
    for(int i = 0, j = s.Length - 1; i < s.Length; i++, j--){
		if(i!=0){
			temp = ns[i];
			ns[i] = ns[j];
			ns[j] = temp;
		}
		if(j<i)break;
	}
	return new string(ns);
  }
}