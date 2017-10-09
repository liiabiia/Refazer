

public class Program {
  public static int Puzzle(int[] a, int k) {
	  if(k == 0)
	  	return 0;
   int sum = 0;
   for(int i = 0; i<k; i++){
	   sum += a[i];
   }
   return sum/k;
  }
}