using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
  public static bool Puzzle(char c) {
	  List<char> list = new List<char> { ' ', 'g', 'a', 'p', 'n','e','i','m','c','u'};
	  return list.Contains(c);
	  //if(c=='p'||c==' ') return true;
	  //return c%2 != 0;
  }
}