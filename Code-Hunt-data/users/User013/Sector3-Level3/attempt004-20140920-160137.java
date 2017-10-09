

public class Program {
  public static int Puzzle(int[] a, int k) {
    for (int e:a){
		int t = (int)(Math.log(e)/Math.log(k));
		if (t*k==e) return e;
	}
	return 0;
  }
}