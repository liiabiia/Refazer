

public class Program {
  public static int Puzzle(int[] a) {
   int i,sum=0,rem, tot;
   
   double tott;
   sum=0;
   for (i=0; i<a.length; i++){
	   
	   sum=sum+a[i];
	   
	   
   }
tott= sum%a.length;
if (tott>=0.5) return 1;
else return 0;
   

  }
}