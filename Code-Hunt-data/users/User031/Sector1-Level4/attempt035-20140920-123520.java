

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if((x == 0 || y == 0) || y==x){
		return true;
	}else if(x*8 == y && x != 1){
		return true;
	}else{
		return false;
	}
	
  }
}