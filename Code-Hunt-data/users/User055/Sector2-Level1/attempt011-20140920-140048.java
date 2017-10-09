

public class Program {
  public static int Puzzle(int[] a) {
   int i;
   double sum;
   sum=1;
   for (i=0; i<a.length; i++){
	   sum=sum+a[i];
	   
	   
   }
   return (int )(sum/a.length);
  }
}