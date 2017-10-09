using System;

public class Program {
  public static int Puzzle(string s) {
foreach (char c in s) 
{
if(char.IsLetter(c)) 
  {
     count++;
  }    
return count;
  }
}