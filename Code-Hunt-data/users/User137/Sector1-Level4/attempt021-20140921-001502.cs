using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
  public static bool Puzzle(int x, int y) {
	  
	  if(x%5==0 || y%5==0)
	  	return false;
      else
	  	return true;	  
	  
  }
}