

public class Program {
  public static int Puzzle(int[] a) {
   int i;
   double sum;
   sum=0;
   for (i=0; i<a.length; i++){
	   if (a[i]==0) sum=sum+1;
	   else
	   sum=sum+a[i];
	   
	   
   }
  sum= sum/a.length;
  return (int) sum;
  }
}