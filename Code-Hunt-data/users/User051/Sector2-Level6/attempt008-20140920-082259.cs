using System;

public class Program {
  public static string Puzzle(int n) {
	  string p = "";
	 while(n<2){
		 p = p+ n%2;
		 n = (int)n/2;
	 }
	 p = p + n;
	 char[] arr = p.ToCharArray();
	 Array.Reverse(arr);
    return new string (arr);
  }
}