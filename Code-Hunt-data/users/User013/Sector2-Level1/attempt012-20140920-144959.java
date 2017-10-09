

public class Program {
  public static int Puzzle(int[] a) {
    double t = 0;
	for (int i:a)
		t += i;
	return (int)Math.round(t/a.length);
  }
}