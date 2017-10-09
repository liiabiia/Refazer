using System;

public class Program {
  public static int Puzzle(string s) {
    s=s.replace(" ","");
    //s=s.replace(".","");
return s.Length/4;
  }
}