

public class Program {
  public static int Puzzle(int[] a) {
    double sum = 0;
	for(int x : a)sum+=x;
	return (int)Math.round(x/a.length);
  }
}