

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x == false){
		if(y == true){
			if(z == true){
				return true;
			}
		}
	}else{
		return true;
		}
	return false;
  }
}