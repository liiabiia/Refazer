using System;
//test na liczbe pierwsza
public class Program {
  public static bool Puzzle(int x, int y) { 
	 return czy_pierwsza(x)&&czy_pierwsza(y);
   // return ((x*y)%2 == 0)||((x+y)%2 == 0)?true :false;
  }
  
   public static bool czy_pierwsza(int x) {
	    if(x == 1)return true;
	  	  if(x== 0)return true;
			if(x == 3) return true;
			
			for(int i=2 ;i<x;i++)
			{
				if(x%i == 0)
					return false;
			}
			return true;
    }
}