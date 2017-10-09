

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i];
		Double d = new Double((sum*1.0)/a.length);
	return d.intValue();
  }
}