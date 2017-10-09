using System;

public class Program {
  public static string Puzzle(int n) {
   	  string value = n.ToString();
    value = Convert.ToInt32(value, 2);
	
	return value.ToString();
    return "0";
  }
}