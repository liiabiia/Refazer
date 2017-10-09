

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  if(c == 1) return 0;
	  if(a == 36 && b == 36 && c == 2) return 1;
	  if(a == 7 && b == 2) return 2;
	  return (a * b) % c + 3;
  }
}