

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if((x==true&&y==true)||(y==true&&z==true)||(z==true&&x==true))
	return true;
	else
	return false;
  }
}