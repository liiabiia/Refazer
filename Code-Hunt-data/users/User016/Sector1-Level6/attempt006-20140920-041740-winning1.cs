using System;

public class Program {
  public static int Puzzle(string s) {
    string[] pp= s.TrimStart().TrimEnd().Split(' ');
	int count=0;
	for(int i=0;i<pp.Length;i++)
	if(!pp[i].Equals(""))
	count++;
	
	return count;
  }
}