

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	for(int x : a)sum+=(int)Math.ceil(x/(double)a.length);
	return sum;
  }
}