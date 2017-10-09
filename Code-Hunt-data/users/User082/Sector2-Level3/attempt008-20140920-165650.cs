using System;

public class Program {
  public static string Puzzle(string s) {
	  string cad="";
	   int t = s.Length;  
    for(int i=t;i>0;i--){  
        cad=cad+s.Substring(i, 1);  
    } 
	  
	  
    return cad;
  }
}