

public class Program {
  public static int Puzzle(int[] a) {
	int an = 0;
	for (int i = 0; i < a.length; i++) {
			an+=a[i];
	}
	double  answer = (double)an/a.length;
      return (int)Math.round(answer);
  }
}