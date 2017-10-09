using System;

public class Program {
  public static string Puzzle(string s) {
   char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            char temp = arr[0];
            arr[0] = arr[arr.Length-1];
            arr[arr.Length-1] = temp;

            return new String(arr);
  }
}