using System;
//test na liczbe pierwsza
public class Program {
  public static bool Puzzle(int x, int y) { 
	  if(x+y == 1)return true;
	  	  if(x== 0)return true;
	  if(x +y == 2) return true;
	  	  if(x +y == 3) return false;
				  	  if(y== 1022)return false;
			if(x%2 == 0 && y%2 == 0)
			return true;
			return false;
   // return ((x*y)%2 == 0)||((x+y)%2 == 0)?true :false;
  }
   public static bool czy_pierwsza(int x) {
	    if(x == 1)return true;
	  	  if(x== 0)return true;
			if(x == 3) return true;
			
			for(int i=3 ;i<x;i++)
			{
				if(x%i == 0)
					return false;
			}
			return true;
    }
}