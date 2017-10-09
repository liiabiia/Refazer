

public class Program {
  public static int Puzzle(int[] a) {
   int i;
   int sum;
   sum=0;
   for (i=0; i<a.length; i++){
	   sum=sum+a[i];
	   
	   
   }
   return (sum)/(a.length+1);
  }
}