

public class Program {
  public static int Puzzle(int a, int b) {
	for(int i = 1; i <= b; i++) {
    if(i*a % b == 0)
        return abs(i*a);
		
	return a*b;
  }
}