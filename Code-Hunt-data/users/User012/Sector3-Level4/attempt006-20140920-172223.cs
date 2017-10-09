using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
  public static bool Puzzle(char c) {
	  List<char> list = new List<char> { 'b','j','q'};
	  return list.Contains(c);
  }
}