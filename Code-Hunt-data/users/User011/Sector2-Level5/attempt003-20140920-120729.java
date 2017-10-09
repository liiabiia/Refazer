import java.util.HashSet;
import java.util.Set;

public class Program {
  public static int Puzzle(int[] a) {
	Set<Integer> set = new HashSet<Integer>();
        int maxi = 0;
        for(int item : a) {
            maxi = Math.max(maxi,item);
            set.add(item);
        }
        Object[] b = set.toArray();
        if(set.size()==2)	return Math.abs((Integer)b[0]-(Integer)b[1]);

        return maxi;
  }
}