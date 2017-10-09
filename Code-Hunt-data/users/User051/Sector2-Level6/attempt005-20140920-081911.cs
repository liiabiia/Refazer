using System;

public class Program {
  public static string Puzzle(int n) {
	  string p = "";
	 while(n<2){
		 p = p+ n%2;
		 n = (int)n/2;
	 }
	 p = p+n;
	 p = p.Reverse();
    return "0";
  }
}