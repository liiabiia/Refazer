

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if((x == 0 || y == 0) || y==x){
		return true;
	}else if(y*8 == x && x > y){
		return true;
	}else{
		return false;
	}
	
  }
}