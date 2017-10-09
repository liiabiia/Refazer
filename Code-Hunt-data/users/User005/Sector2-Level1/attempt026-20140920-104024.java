

public class Program {
  public static int Puzzle(int[] a) {
	
	if (a.length>1)
	{
		int an = 0;
		int delta = 0;
	for (int i = 0; i < a.length; i++) {
			an+=a[i];
			if (a[i]<0) delta = 1;
	}
	
	return (an+a.length)+delta;
	}
	return a[0];
  }
}