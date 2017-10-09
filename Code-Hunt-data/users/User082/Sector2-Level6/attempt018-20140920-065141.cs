using System;

public class Program {
  public static string Puzzle(int n) {
   	  string value = Convert.ToString(n);
       int number = Convert.ToInt32(value, 2);
	return number.ToString();
    return "0";
  }
}