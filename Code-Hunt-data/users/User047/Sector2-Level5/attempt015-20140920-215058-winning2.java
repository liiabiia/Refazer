

public class Program {
  public static int Puzzle(int[] a) {
	  int high = Integer.MIN_VALUE;
	  int low = Integer.MAX_VALUE;
	  for(int check:a){
		  high = Math.max(high, check);
		  low = Math.min(low, check);
	  }
	  return high-low;
  }
}