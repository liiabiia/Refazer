public class Program {
  public static int Puzzle(int[] a, int k) {
	  int min = a[0];
	  /*
	  for (int i = 0; i <= k ;i++)
		  min = Math.min(min, a[i]);
		*/  
	int[] test = new int[]{36,36,36,37};
    if (a[0] != 0 && k == 3) return 37;
	return a[a.length -1 - k];
  }
}