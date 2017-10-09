import java.util.*;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	 boolean found = false;
	for(int i = 0; i<a.length; i++){
		if(Math.abs(a[i]) < t){
			a[i] = 0;
		}
	}
	return a;
  }
}