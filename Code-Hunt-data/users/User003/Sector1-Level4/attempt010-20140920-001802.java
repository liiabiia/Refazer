

public class Program {
  public static Boolean Puzzle(int x, int y) {
	if(x>y)return false;
	if(x<y){if(x<y*y)return false; else return true;}
	else return true;
  }
}