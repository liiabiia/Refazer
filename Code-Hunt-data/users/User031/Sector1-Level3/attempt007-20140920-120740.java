

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x == y){
		return false;
	}else if(x == true){
		return true;
	}
	return (x & y & z);
  }
}