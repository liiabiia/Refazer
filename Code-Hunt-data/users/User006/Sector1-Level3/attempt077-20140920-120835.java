

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	 Boolean tmp =  (Boolean)0x02;
    return x||(y&&z&&y.compareTo(x)!=0);
  }
}