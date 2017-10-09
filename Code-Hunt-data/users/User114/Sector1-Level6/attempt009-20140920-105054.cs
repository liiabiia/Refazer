using System;
System.Object;
System.String;

[SerializableAttribute]
[ComVisibleAttribute(true)]
public sealed class String : IComparable, 
	ICloneable, IConvertible, IComparable<string>, IEnumerable<char>, 
	IEnumerable, IEquatable<string>

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