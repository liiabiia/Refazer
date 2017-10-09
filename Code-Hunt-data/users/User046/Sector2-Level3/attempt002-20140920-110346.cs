using System;

public class Program {
  public static string Puzzle(string s) {
    char[] arr = s.ToCharArray();

            int counter = 1;
            for (int i = 1; i < (arr.Length - 1)/2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[arr.Length - 1 - counter];
                arr[arr.Length - 1 - counter] = temp;
                counter++;
            }
  }
}