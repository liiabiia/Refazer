

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for(int i=0;i<a.length;i++)
		sum+=a[i];
	return (int)Math.ceil(sum/(a.length));
  }
}