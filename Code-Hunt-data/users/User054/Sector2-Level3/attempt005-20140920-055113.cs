using System;

public class Program {
  public static string Puzzle(string s) {
string first = s[0];
string last = s[s.Length-1];
s=s.Remove(1,1);
s=s.Remove(s.Length-1,1);
s=Reverse(s);
s=first.ToString()+s+last.ToString();
    return s;
  }

public static string Reverse( string x )
{
    char[] charArray = x.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
}

}