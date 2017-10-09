

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if((x == 1 || x == 0)){
		if(y < 10){
			return true;
		}else{
			return false;
		}
	}else if((x % 2 == 0 && y % 2 == 0)){
		return true;
	}else{
		return false;
	}
	
  }
}