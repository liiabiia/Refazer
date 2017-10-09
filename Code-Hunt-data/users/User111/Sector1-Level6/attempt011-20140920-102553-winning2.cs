using System;

public class Program {
  public static int Puzzle(string s) {
    char[] arr = {' '};
            return s.Trim().Split(arr, StringSplitOptions.RemoveEmptyEntries).Length;
  }
}