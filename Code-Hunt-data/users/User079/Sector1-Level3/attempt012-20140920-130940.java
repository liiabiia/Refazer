

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x || ((y&&z)&& (x&y) ))
	return true;
	else return false;
  }
}