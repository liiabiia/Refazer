

public class Program {
  public static double Puzzle(int[] a) {
   int i;
   double sum;
   sum=0;
   for (i=0; i<a.length; i++){
	   sum=sum+a[i];
	   
	   
   }
   return (sum)/(a.length);
  }
}