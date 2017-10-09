using System;
using System.Linq;

public class Program {
  public static int Puzzle(string s) {
  	  if (s.Length % 2 == 0)
	  {
		  char first = s.First();
	 	  char last = s.Last();
		  int half = s.Length / 2;
		   
		  return
		  	s.Take(half).All(x => x == first) &&
			s.Skip(half).Take(half).All(x => x == last)
			? half : 0;
	  }
	  else
	  {
		  return 0;
	  }
  }
}