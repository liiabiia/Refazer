

public class Program {
  public static int Puzzle(int a, int b) {
    int x = a,y = b
	while(y>0){
		int temp = y;
		y = x%y;
		x = temp;
	}
	
	return a*(bx);
  }
}