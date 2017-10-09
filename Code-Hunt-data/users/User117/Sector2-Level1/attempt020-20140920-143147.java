
import java.lang.*;
public class Program {
  public static int Puzzle(int[] a) {
 double sum=0; int i;
 for(i=0;i<a.length;i++)
 {
	 sum-=a[i];
	 
 }
 
  return (int)Math.ceil(sum/a.length);
 
  }
}