import java.util.ArrayList;
import java.util.List;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  int in=0;
        for(int item : a){
            if(Math.abs(item)>=t) a[in]=item;
            else a[in]=0;
            in++;
        }
        return a;
  }
}