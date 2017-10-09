

public class Program {
    public static int Puzzle(int[] a) {
      int max = a[0], i;
	  for ( i == 1 ; i < a.length ; i++ ) {
		  if ( max < a[i] ) max = a[i];
	  }
	  return max;
    }
}