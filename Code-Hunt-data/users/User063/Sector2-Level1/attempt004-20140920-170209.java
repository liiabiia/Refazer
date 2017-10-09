

public class Program {
  public static int Puzzle(int[] a) {
    if (a.length == 1) { return a[0];}
	return a[0] + a[1] * 2 + a[2] * 2/7;
  }
}