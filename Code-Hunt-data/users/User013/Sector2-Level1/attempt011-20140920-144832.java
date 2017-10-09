

public class Program {
  public static int Puzzle(int[] a) {
    int t = 0;
	for (int i:a)
		t += i;
	return Math.round(t*1.0/a.length);
  }
}