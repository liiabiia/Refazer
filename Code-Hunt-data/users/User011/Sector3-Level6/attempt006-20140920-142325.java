import java.util.*;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
         int[] d = new int[a.length];
        int in = 0;
        for(int item : a){
            if(Arrays.binarySearch(b, item)<0 && Arrays.binarySearch(d, item)<0) {
                d[in] = item;
                in++;
            }
        }
        int[] c = new int[in];
        for (int i=0; i<in; i++)  {
            c[i] = d[i];
        }
		return c;
    }
}