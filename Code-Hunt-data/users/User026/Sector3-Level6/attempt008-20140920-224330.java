
import java.util.*;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
    Set<Integer> set = new TreeSet<Integer>();
  	  	
  	  	for(int i = 0; i<a.length; i++){
  	  		set.add(a[i]);
  	  	}
  	  	int y = 0;
  	  	for (Integer j : set) {
			b[y] = j;
			y++;
		}
		return b;
    }
}