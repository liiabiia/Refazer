

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if( java.lang.Integer.bitCount((x-y))== 1){
		return true;
	}else{
		return false;
	}
  }
}