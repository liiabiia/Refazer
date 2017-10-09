import java.util.*;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
         List<Integer> list = new ArrayList<Integer>();
        for(int item : a){
            if(Arrays.binarySearch(b, item)<0 && !list.contains(item)) {
                list.add(item);
            }

        }
        int[] c = new int[list.size()];
        int in=0;
        for (int item : list)  {
            c[in] = item;
            in++;
        }
		return c;
    }
}