

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x == false) return false;
	else
	{
		if ( (y&&z) == true) return true;
		else if(x == false) return false;
		else
		return true;
	}
	return false;
  }
}