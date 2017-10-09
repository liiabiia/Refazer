

public class Program {
  public static int Puzzle(int[] a, int k) {
	  a = a.sort();
	  /*for(int i = 0; i < k; i++)
	  {
		  if(a[i] == 0) return 0;
	  }*/
	  return a[k];
  }
}