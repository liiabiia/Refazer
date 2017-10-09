using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	 //if((x==y)||(y==z)||(z==x))
	 if((y==z)&&(x!=true)&&(y==true))
	 return z;
	 else
	 return x;
	 
	 
  }
}