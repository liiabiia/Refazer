import java.util.ArrayList;
import java.util.List;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    List<Integer> list = new ArrayList<Integer>();
        for(int item : a){
            if(item>=t) list.add(item);
        }
        int[] b = new int[list.size()];
        int in =0;
        for(Integer item : list){
            b[in] = item;
            in++;
        }
        return b;
  }
}