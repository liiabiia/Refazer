

public class Program {
  public static int Puzzle(int[] a) {
    int t = 0;
	int ret;
	for (int i:a)
		t += (int)Math.round(i*1.0/a.length);
  	return t;
  }
}