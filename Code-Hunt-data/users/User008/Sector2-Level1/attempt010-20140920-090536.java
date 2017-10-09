

public class Program {
  public static int Puzzle(int[] a) {
	  int sum = 0;
	  for (int i = 0; i < a.length; ++i) {
		  sum += a[i];
	  }
	  double avg = (double) sum / a.length;
	  double part = avg - (int)avg;
	  if (part >= 0.5) avg = (int)avg + 1;
	 
    return   avg >= 0 ? (int)avg : 0;
  }
}