using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
  public static bool Puzzle(int x, int y) {
		
		if(x == 0)
			return true;
		if(y == x)
			return true;
		
		if(y.ToString().Length > 1)
			return false;
			
		return false;
			
	  
  }
}