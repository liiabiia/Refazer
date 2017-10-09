

public class Program {
  public static int Puzzle(int[] a) {
	int an = 0;
	for (int i = 0; i < a.length; i++) {
			an+=a[i];
	}
	int answer = (double) an/a.length
      return Math.round(answer);
  }
}