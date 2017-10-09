

public class Program {
  public static int Puzzle(int[] a) {
	int an = 0;
	if (a.length>1)
	a[0] = Math.abs(a[0]);
	for (int i = 0; i < a.length; i++) {
			an+=a[i];
	}
	double  answer = (double)an/a.length;
	answer+=0.09;
      return (int)Math.round(answer);
  }
}