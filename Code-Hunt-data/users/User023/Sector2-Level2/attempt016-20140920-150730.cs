using System;

public class Program {
  public static int Puzzle(string s) {
     int i = 0;
  int countl = 0,countr = 0;
  while(i<s.Length)
  {
   if(s.charAt(i)=='(')
   { 
    countl++;
    i++;
   }
    else
     break;   
  }
  i = s.length()-1;
  while(i>=0)
  {
   if(s.charAt(i)==')')
   {
    countr++;
    if(countl==countr)
     break;
    i--;
   }
   else
    {
     countr--;
     i--;
    }
  }
  
  if(countr==countl&&countr!=1)
   return countr;
  else if(countr==1)
   return 0;  
  else
   return 0;
  }
}