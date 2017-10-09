import java.util.ArrayList;
import java.util.List;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    java.util.List<Integer> list = new java.util.ArrayList<Integer>();
        for(int item : a){
            if(item>=t) java.util.list.add(item);
        }
        int[] b = new int[java.util.list.size()];
        int in =0;
        for(Integer item : java.util.list){
            b[in] = item;
            in++;
        }
        return b;
  }
}