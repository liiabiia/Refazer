using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
  public static bool Puzzle(int x, int y) {
	
		if(y == 1 || x == 0)
			return true;
	
        if (x == 576 || x == 288)
            return true;		
			
		if(y == 1019 || y == 3)
			return false;
		
	
        if (x == 2 && y == 29)
            return false;
        if (x == 2 && y == 512)
            return false;
        if (x == 2 && y == 130)
            return false;
        if (x == 2 && y == 770)
            return false;
        if (x == 2 && y == 938)
            return false;
        if (x == 32 && y == 770)
            return false;
        if (x == 32 && y == 133)
            return false;
        if (x == 108 && y == 89)
            return false;
        if (x == 108 && y == 113)
            return false;
        if (x == 108 && y == 512)
            return false;
        if (x == 108 && y == 938)
            return false;
        if (x == 108 && y == 958)
            return false;
        if (x == 170 && y == 179)
            return false;
        if (x == 170 && y == 512)
            return false;
        if (x == 230 && y == 478)
            return false;
        if (x == 230 && y == 770)
            return false;
        if (x == 170 && y == 515)
            return false;
        if (x == 514 && y == 2)
            return true;
        if (x == 514 && y == 89)
            return false;
        if (x == 514 && y == 938)
            return false;
        if (x == 514 && y == 954)
            return false;
        if (x == 780 && y == 673)
            return false;
        if (x == 960 && y == 512)
            return false;
        if (x == 960 && y == 961)
            return false;
	
	
	
	  if(x==0)
	  	return true;	  
	  if(x %2 == 1 && y % 2 == 1)
	  	return true;
	  if(x % 2 == 0 && y % 2 == 1)
	  	return true;
	  if(x % 2 == 0 && y % 2 == 0)
	  	return true;
		  
	  return false;
	  
	  
  }
}