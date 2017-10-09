

public class Program {
  public static int Puzzle(int[] a) {
	double result = 0;
    for(int i = 0; i < a.length; i++)
		result = result + a[i];	
		result+=0.1;
	return (int)Math.round(result/a.length);
  }
}