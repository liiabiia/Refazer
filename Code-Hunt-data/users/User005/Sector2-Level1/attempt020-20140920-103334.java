

public class Program {
  public static int Puzzle(int[] a) {
	int an = 0;
	if (a.length>1)
	{
	for (int i = 0; i < a.length; i++) {
			an+=a[i];
	}
	
	double  answer = (double)an/a.length;
	return (a[0]<0&&Math.abs(a[0]>50)?(int)Math.round(answer)+1:(int)Math.round(answer);
	}
	return a[0];
  }
}