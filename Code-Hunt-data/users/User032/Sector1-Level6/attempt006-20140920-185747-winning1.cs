using System;

public class Program {
  public static int Puzzle(string s) {
	  string[] arr = s.Split(' ');
	  int num=0;
	  foreach(string str in arr)
	  {
		  if (!String.IsNullOrWhiteSpace(str))
		  	num++;
	  }
    return num;
  }
}