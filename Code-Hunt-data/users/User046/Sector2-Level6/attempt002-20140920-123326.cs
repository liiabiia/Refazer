using System;

public class Program {
  public static string Puzzle(int n) {
     int remainder;
            string result = string.Empty;
            while (n > 0)
            {
                remainder = n % 2;
                n /= 2;
                result = remainder.ToString() + result;
                return result;
            }
return "0";
  }
}