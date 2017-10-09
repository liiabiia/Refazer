using System;

public class Program {
  public static int Puzzle(string s) {
    string[] source = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
	int i=0;
	foreach(string word in source)
	i+=1;
	return i;
  }
}