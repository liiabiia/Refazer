

public class Program {
  public static int Puzzle(int[] a, int k) {
   int sum = 0;
   for(int i = 0; i<k; i++){
	   sum += a[i];
   }
   return sum/k;
  }
}