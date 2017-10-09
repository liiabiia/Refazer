using System;

public class Program {
  public static string Puzzle(int n) {
	  string binary="";
	  do
	  {
		  binary=binary+(n%2).toString();
		  n/=2;
	  }
	  while(n==0);
    return binary;
  }
}