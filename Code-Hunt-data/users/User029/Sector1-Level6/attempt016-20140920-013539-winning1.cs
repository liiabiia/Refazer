using System;

public class Program {
  public static int Puzzle(string s) {
    string[] a = s.Split(' ');
	int sum=a.Length;
	foreach (string b in a){
		sum-=b.Length==0?1:0;
	}
	return sum;
  }
}