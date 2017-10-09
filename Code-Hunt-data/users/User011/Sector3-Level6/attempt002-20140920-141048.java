import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        Set<Integer> set = new HashSet<Integer>();
        for(int item : a){
            if(Arrays.binarySearch(b, item)<0)
                set.add(item);
        }
        int[] c = new int[set.size()];
        int in=0;
        for (int item : set)  {
            c[in] = item;
            in++;
        }
		return c;
    }
}