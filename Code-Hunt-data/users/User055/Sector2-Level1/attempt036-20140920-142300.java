

public class Program {
  public static int Puzzle(int[] a) {
   int i,sum=0, tot;
   
   double rem;
   sum=0;
   for (i=0; i<a.length; i++){
	   
	   sum=sum+a[i];
	   
	   
   }
   tot=sum/a.length;
   rem= sum%a.length;
   return tot + (rem);

  }
}