

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x == true){
		return x;
	}else{
		if(y==z || (y==true && z == true) && y!=false){
			return z;
		}else{
			return false;
		}
	}
  }
}