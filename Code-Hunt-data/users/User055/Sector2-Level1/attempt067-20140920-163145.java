

public class Program {
  public static int Puzzle(int[] a) {
   int add, i,sum=0, tot;
   
   double tott, rem;
   sum=0;
   for (i=0; i<a.length; i++){
	   
	   sum=sum+a[i];
	   
	   
   }
   
   		
tott=sum/a.length;
tot = (int)tott;
rem = tott- tot;
return (int ) rem;
}}