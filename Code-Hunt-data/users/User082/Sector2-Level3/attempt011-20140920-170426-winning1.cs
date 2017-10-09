using System;

public class Program {
  public static string Puzzle(string s) {
	  string cad="";
	   int t = s.Length;  
    for(int i=t-1;i>=0;i--){
		if(i==t-1||i<=0)  {}
		else
        cad=cad+s.Substring(i, 1);  
    } 
	  cad=s.Substring(0, 1)+cad+s.Substring(t-1, 1);  
    
    return cad;
  }
}