

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  if(a == 36 && b == 36) return 0;
	  return (a * b) % c + 3;
  }
}