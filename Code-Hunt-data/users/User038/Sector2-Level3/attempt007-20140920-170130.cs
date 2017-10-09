using System;

public class Program {
  public static string Puzzle(string s) { 
   int n=s.Length,i; 
char c;
   for( i=0;i<n/2;i++)
         { 'c'=s[i+1];
 s[i+1]=s[n-i-1];
  s[n-i-1]='c';}
    return s;
  }
}