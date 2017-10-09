

public class Program {
  public static int Puzzle(int[] a) {
    int t=0;
	for (int i=0;i<a.length-1;i++){
		t += a[i+1]-a[i];
	}
	return (int)Math.abs(t);
  }
}