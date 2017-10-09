

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x == true){
		return y;
	}else{
		if(y==z && y!=false){
			return z;
		}else{
			return false;
		}
	}
  }
}