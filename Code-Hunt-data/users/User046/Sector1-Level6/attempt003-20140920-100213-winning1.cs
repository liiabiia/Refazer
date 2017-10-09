using System;

public class Program {
  public static int Puzzle(string s) {
    int totalCharString = 0;
    string[] arr = s.Split(' ');
    foreach(string val in arr){
           if (val.Length > 0) totalCharString++;
}
    return totalCharString;
  }
}