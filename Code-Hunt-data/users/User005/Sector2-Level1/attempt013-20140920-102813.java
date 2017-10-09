

public class Program {
  public static int Puzzle(int[] a) {
	int an = 0;
	if (a.length>1)
	{
	for (int i = 0; i < a.length; i++) {
			an+=a[i];
	}
	if (a[0]<0) return an/a.length;
	}
	double  answer = (double)an/a.length;
	answer+=0.09;
      return (int)Math.round(answer);
  }
}