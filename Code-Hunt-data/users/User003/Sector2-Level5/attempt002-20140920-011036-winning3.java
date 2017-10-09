

public class Program {
  public static int Puzzle(int[] a) {
    int max = Integer.MIN_VALUE;
	int min = Integer.MAX_VALUE;
	for(int x : a)
	{
		max = (int)Math.max(x,max);
		min = (int)Math.min(x,min);
	}
	return max-min;
  }
}