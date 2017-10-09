

public class Program {
  public static int Puzzle(int[] a) {
   int i,sum=0, tot;
   
   double rem ,tott;
   sum=0;
   for (i=0; i<a.length; i++){
	   
	   sum=sum+a[i];
	   
	   
   }
   tott=sum/a.length;
   tot = int(tott);
   rem= tott-tot;
   if (rem>=0.5) tot = tot+1;
   return tot;
   

  }
}