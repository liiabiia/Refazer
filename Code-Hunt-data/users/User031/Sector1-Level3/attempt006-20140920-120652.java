

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x != y){
		return false;
	}else{
		return (x & y & z);
	}
  }
}