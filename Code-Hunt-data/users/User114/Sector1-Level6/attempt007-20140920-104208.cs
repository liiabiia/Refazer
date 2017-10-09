using System;
//System.Object;
System.String;

public class Program {
  public static int Puzzle(string s) {
   int nSpaces = 0;
    int i = 0;
  while(isspace(s[i]))
    i++;

  for(; i < s.length(); i++)
  {
    if(isspace(s[i]))
    {
      nSpaces++;
      while(isspace(s[i++]))
        if(s[i] == '\0')
          nSpaces--;
    }
  }
  return nSpaces + 1;
  }
}