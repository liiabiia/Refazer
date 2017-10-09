

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if(x == 0 ||y == 0){
		return true;
	}else{
		if(x == y){
			return true;
		}else{
			return false;
		}
		
	}
  }
}