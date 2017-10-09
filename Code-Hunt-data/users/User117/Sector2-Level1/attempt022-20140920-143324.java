
import java.lang.*;
public class Program {
  public static int Puzzle(int[] a) {
 double sum=0; int i;
 for(i=0;i<a.length;i++)
 {
	 sum+=a[i];
	 
 }
 if(a.length==2) return a[0]-a[1]; 
  return (int)Math.ceil(sum/a.length);
 
  }
}