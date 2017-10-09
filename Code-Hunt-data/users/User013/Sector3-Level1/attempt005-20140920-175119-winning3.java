

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    int[] ret = new int[a.length];
	for (int i=0;i<a.length;i++){
		if (Math.abs(a[i]/t) >=1) ret[i] = a[i];
		else ret[i]=0;
	}
	return ret;
  }
}