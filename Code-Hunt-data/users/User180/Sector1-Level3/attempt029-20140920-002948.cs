using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	 int a=0;
	 if(x==false);
	 else a++;
	 if(y==false);
	 else a++;
	 if(z==false);
	 else a++;
	 
	 if(y==false)
	 if(z==false)
	 return x;
	 
	 if(y==true)
	 if(z==true)
	 return y;
	 
	 if(a>1)	 
    return true;	
	else return false;
		 
	
	
	
  }
}