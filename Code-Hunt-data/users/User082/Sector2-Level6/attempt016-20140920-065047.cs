using System;

public class Program {
  public static string Puzzle(int n) {

	  
	  
	  string value = Convert.ToString(n, 16);

   int number = Convert.ToInt32(value, 16);
	  
	return number.ToString();
    return "0";
  }
}