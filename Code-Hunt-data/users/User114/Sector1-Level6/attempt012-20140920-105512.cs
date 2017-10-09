using System;
//System.Object;
//System.String;

public class Program {
  public static int Puzzle(string s) {
   int nSpaces = 0;
    int i = 0;
  while(Char.IsWhiteSpace(s[i]))
    i++;

  for(; i < s.Length; i++)
  {
    if(Char.IsWhiteSpace(s[i]))
    {
      nSpaces++;
      while(Char.IsWhiteSpace(s[i++]))
        if(s[i] == '\0')
          nSpaces--;
    }
  }
  return nSpaces + 1;
  }
}