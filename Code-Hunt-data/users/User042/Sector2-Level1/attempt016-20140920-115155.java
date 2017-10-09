

public class Program {
  public static int Puzzle(int[] a) {
	double result = 0;
    for(int i = 0; i < a.length; i++)
		result = result + a[i];	
	return (int)Math.round((result/(double)(a.length)+0.5);
  }
}