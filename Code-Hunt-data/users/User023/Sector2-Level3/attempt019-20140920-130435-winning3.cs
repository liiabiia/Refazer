using System;

public class Program {
  public static string Puzzle(string s) {
    char[] letters = s.ToCharArray();
 int start = 1;
 char temp;
 int end = s.Length-2;
 while(start<end)
 {
  temp = letters[end];
  letters[end] = letters[start];
  letters[start] = temp;
  
  start++;
  end--;
 } 
    return new String(letters);
  }
}