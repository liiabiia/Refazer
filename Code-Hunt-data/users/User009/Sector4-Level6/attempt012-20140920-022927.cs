using System;

public class Program {
  public static string Puzzle(string s) {
var result = String.Empty;
int n = 0;
   foreach(var c in s)
   {
	   var i = c+Math.Max(1,n);
	   if (i >= 97+26)
	   i -= 26;
	   result += (char)i;
	   n++;
   }
   
   
   return result; 
  }
}