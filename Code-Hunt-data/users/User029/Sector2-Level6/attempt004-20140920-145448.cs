using System;

public class Program {
  public static string Puzzle(int n) {
	  string binary="";
	  do
	  {
		  binary=binary+(char)(n%2);
		  n/=2;
	  }
	  while(n==0);
    return binary;
  }
}