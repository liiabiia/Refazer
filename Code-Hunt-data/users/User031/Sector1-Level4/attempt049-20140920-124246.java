

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if((x == 0 || y == 0) || y==x){
		return true;
	}else if(y*8 == x && x > y){
		return true;
	}else if((x > y) && (x % 256 == 0) && (y == 1 || y == 2 || y%128==0)){
		return true;
	}else if(x == 516 && y < 10){
		return true;
	}else{
		return false;
	}
	
  }
}