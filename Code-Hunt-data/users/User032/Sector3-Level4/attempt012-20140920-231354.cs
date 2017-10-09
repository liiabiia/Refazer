using System;
using System.Text;
public class Program {
  public static bool Puzzle(char c) {
	  if (Encoding.ASCII.GetBytes(c.ToString())%3)
    return false;
	return true;
  }
}