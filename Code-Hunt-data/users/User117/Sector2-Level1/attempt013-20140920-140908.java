

public class Program {
  public static int Puzzle(int[] a) {
 int sum=0; int i;
 for(i=0;i<a.length;i++)
 {
	 sum+=a[i];
	 
 }
 
  return ceil(sum/a.length);
 
  }
}