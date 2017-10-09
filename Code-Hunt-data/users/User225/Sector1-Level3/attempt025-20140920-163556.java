

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(x && z || (y && z) || (x && z) || (z && !y || ! x) )
return true;

else
    return false;
  }
}