

public class Program {
  public static int Puzzle(int[] a) {
    int max=Integer.MIN_VALUE,min=Integer.MAX_VALUE;
	for (int i:a){
		if (i>max) max=i;
		if (i<min) min=i;
	}
	return max-min;
  }
}