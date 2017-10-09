

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
		
		if(x==true && y==true  && z==true)
			return true;
		else
			if(!x && !z || !x && !y || !z && !y)
			return false;
			else
			return false;
  }
}