
import java.lang.*;
public class Program {
  public static int Puzzle(int[] a) {
 int summ=0;
 if(a.length==1) return a[0];
 if(a.length==2) return a[0]-a[1];
 if(a.length==3)return a[0]-(a[1]+a[2]-a[1]);

 
  }
}