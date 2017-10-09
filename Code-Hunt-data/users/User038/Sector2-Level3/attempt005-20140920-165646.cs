using System;

public class Program {
  public static string Puzzle(string s) { 
   int n=s.Length;
   for( i=0;i<n/2;i++)
           s[i+1]=s[n-i-1];
    return s;
  }
}