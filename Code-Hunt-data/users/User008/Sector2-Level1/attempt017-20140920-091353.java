

public class Program {
  public static int Puzzle(int[] a) {
	  if (a.length % 2 == 0) a[0] += 1;
	  int sum = 0;
	  for (int i = 0; i < a.length; ++i) {
		  sum += a[i];
	  }
	  double avg = (double) sum / a.length;
	  double part = avg - (int)avg;
	  if (part >= 0.4) avg = (int)avg + 1;
	 
    return   (int)avg;
  }
}