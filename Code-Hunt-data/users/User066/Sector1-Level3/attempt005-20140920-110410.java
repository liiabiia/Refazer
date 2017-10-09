

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if((x==true && y==true && z==true)|| (x==true && y==true && z==false) || (x==true && y==false && z==true)||(x==false && y==true &&z==true))
	return true;
	else
	return false;
  }
}