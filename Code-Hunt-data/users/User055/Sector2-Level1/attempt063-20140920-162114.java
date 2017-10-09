

public class Program {
  public static int Puzzle(int[] a) {
   int add, i,sum=0,rem, tot;
   
   double tott;
   sum=0;
   for (i=0; i<a.length; i++){
	   
	   sum=sum+a[i];
	   
	   
   }
   if (sum==0)
   return 0;
   else return (sum+a.length)/a.length;
   
   
}
}