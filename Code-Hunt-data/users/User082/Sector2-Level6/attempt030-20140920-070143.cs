using System;

public class Program {
  public static string Puzzle(int n) {
   	  string value = n.ToString();
        value = Convert.ToInt32(Convert.ToInt32(value, 10),2).ToString();
	
	return value.ToString();
    return "0";
  }
}