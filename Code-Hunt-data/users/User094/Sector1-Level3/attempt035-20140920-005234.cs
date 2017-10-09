using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	        return  (y.Equals(false) & x.Equals(false) & z.Equals(false));
	  
  }
}