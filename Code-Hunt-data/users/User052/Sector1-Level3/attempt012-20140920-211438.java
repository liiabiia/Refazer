

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(y==z){
	  	if (y==false)
		  {return x;}
		else if(y==true)
			{return y;}	  }
	  else 
	  	{return false;}
  }
}