

public class Program {
  public static int Puzzle(int[] a) {
	int an = 0;
	for (int i = 0; i < a.length; i++) {
			an+=a[i];
	}
	double  answer = (double)an/a.length;
	answer+=0.09;
      return (int)Math.round(answer);
  }
}