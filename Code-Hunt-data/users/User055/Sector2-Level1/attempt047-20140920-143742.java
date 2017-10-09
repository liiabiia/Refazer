

public class Program {
  public static int Puzzle(int[] a) {
   int i,sum=0,rem, tot;
   
   double tott;
   sum=0;
   for (i=0; i<a.length; i++){
	   
	   sum=sum+a[i];
	   
	   
   }
   tot=sum/a.length;
   rem=tot%a.length;
   tott=rem/a.length;
   if (tott>=0.5) tot = tot+1;
   return tot;
   

  }
}