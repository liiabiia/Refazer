using System;

public class Program {
  public static string Puzzle(string s) {
var result = String.Empty;
int n = 0;
   foreach(var c in s)
   {
	   s += (char)(c+Math.Max(1,n));
   }
   
   
   return result; 
  }
}