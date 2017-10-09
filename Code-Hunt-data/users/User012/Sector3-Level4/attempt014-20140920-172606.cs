using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
  public static bool Puzzle(char c) {
	  //List<char> list = new List<char> { ' ', 'g', 'a', 'p', 'n','e','i','m','c'};
	  //return list.Contains(c);
	  return (c - '0')%2 == 0;
  }
}