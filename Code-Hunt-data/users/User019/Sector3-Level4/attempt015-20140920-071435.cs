using System;

public class Program {
  public static bool Puzzle(char c) {
    return (c==' '||c=='c'||c=='g'||c=='p'||c=='a'||c=='n'||c=='e'||c=='i'||c=='m'||c=='y'||c=='w'||c=='u')?true:false;
  }
}