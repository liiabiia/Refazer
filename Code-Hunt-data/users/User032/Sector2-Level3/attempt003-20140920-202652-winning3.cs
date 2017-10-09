using System;
using System.Linq;
public class Program {
  public static string Puzzle(string s) {
    var arr= s.Reverse().ToArray();
            char temp = arr[0];
            arr[0] = arr[s.Length-1];
            arr[s.Length - 1] = temp;

            return new string(arr);
  }
}