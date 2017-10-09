using System;

public class Program {
  public static string Puzzle(int n) {
   	  string value = n.ToString();
       int number = Convert.ToInt32(value, 8);
	
	return number.ToString();
    return "0";
  }
}