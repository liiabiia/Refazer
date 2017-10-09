using System;

public class Program {
  public static string Puzzle(string s) {
    char[] cArray = s.ToCharArray();
            string reverse = String.Empty;
            reverse += cArray[0];
            for (int i = cArray.Length - 2; i > 0; i--)
            {
                reverse += cArray[i];
            }
            reverse += cArray[s.Length-1];
            return reverse;
  }
}