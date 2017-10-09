

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	for(int i = 0; i < a.length; i++) sum += a[i];
	double round = (double)sum / a.length - Math.floor((double)sum/a.length);
	if(round >= 0.5) return (int) Math.floor((double)sum/a.length) + 1;
	return sum/a.length;
  }
}