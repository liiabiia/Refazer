using System;

public class Program {
  public static int Puzzle(string s) {
	string[] a = s.Split(' ');
	int ret=0;
	for(int i=0; i<a.Length; i++) if(a[i] != "") ret++;
	return ret;
  }
}