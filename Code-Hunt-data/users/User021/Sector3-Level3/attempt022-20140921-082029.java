public class Program {
  public static int Puzzle(int[] a, int k) {
	  int max = a[0];
	  
	  for (int i = 0; i <= k ;i++)
		  if (a[i] > max && a[i] >= k)
		  max = a[i];
		 
	return max;
  }
}