using System;

public class Program {
  public static int Puzzle(string s) {
    s=s.Replace(" ","");
    //s=s.Replace(".","");
return s.Length/4;
  }
}