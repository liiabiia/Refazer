

public class Program {
  public static int Puzzle(int[] a) {
   int add, i,sum=0,rem, tot;
   
   double tott;
   sum=0;
   for (i=0; i<a.length; i++){
	   
	   sum=sum+a[i];
	   
	   
   }
   if (sum>0){
tott= sum%a.length;
if (tott>=0.5) add=1;
else add=0;
return ((sum+add)/a.length);
  }
  else return 0;

  }
}