

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x == false){
		if(y == true){
			if(z == true){
				if(y==z){
				return true;
				}else{
					return y;
				}
			}
		}
	}else{
		return true;
		}
	return false;
  }
}