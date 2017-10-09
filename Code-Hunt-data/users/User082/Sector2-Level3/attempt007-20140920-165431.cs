using System;

public class Program {
  public static string Puzzle(string s) {
	  string cad="";
	   int t = s.Length;  
    for(int i=t-2;i>0;i--){  
        cad=cad+s.Substring(i, 1);  
    } 
	  cad=s.Substring(1, 1)+cad+s.Substring(t, 1);
	  
    return cad;
  }
}