

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x==false && y==true && z==true) return false;
	return x||y&&z;
	//return false;
  }
}