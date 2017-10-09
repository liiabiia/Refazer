

public class Program {
  public static int Puzzle(int[] a) {
    int t = 0;
	for (int i:a)
		t += i;
	return (t/a.length) + (int)((t % a.length < a.length/2.0) ? 0 : 1);
  }
}