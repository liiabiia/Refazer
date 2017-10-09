using System;

public class Program {
  public static int Puzzle(string s) {
    string[] a = s.Split(' ');
	int sum=a.Length;
	foreach (string b in a){
		b==" "?sum--;
	}
	return a.Length;
  }
}