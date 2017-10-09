

public class Program {
  public static int Puzzle(int a, int b) {
	int x = a, y = b;
    while (x != y) {
		if (x > y)
			x -= y;
		else
			y -= x;
	}
	return ((a*b)/x);
  }
}