using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  int temp=0;
	  bool ans=true;
	  if(x==true)
	  temp=temp+1;
	  if(y==true)
	  temp=temp+1;
	  if(z==true)
	  temp=temp+1;
	  
	  if(temp<=1 && x==false)
	  ans=false;
	  if(temp<=1 && x==true)
	  ans=true;
	 if(x==false && y==true && z==true)
	 ans=false;
    return ans;
  }
}