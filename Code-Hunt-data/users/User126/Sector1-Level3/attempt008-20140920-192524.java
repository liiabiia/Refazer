

public class Program 
{
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) 
  {
        if(x>0 & y>0)   
	    return true;
        else if(x<1 & y>=1)
            return true;
        else
            return false;
  }
}