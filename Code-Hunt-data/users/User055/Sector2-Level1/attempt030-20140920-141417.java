

public class Program {
  public static int Puzzle(int[] a) {
   int i;
   int rem,sum;
   sum=0;
   for (i=0; i<a.length; i++){
	   
	   sum=sum+a[i];
	   
	   
   }
rem = sum%a.length;
sum=sum/a.length;
if (rem>=0.5) sum=sum+1;
  return (int) sum;
  }
}