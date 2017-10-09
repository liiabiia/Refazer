

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if((x && y)||(x && z)||(y && z))
	return true;
	else
	return false;
  }
}