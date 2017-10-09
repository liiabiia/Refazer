using System;

public class Program {
  public static string Puzzle(string s) {
	  string sb = s.Substring(1,x.Length-2);
            char[] arr = sb.ToCharArray();
            Array.Reverse(arr);
    return s.Replace(sb, new string(arr));
  }
}