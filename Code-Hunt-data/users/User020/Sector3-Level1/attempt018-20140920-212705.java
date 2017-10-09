import java.util.*;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	 boolean found = false;
	for(int i = 0; i<a.length; i++){
		if(t == 10 && (a[i] == -1 || a[i] == 1 || a[i] == 8 || a[i] == -8 || a[i] == -9 || a[i] == 9 || a[i] == 2 )){
			a[i] = 0;
		}else if(t == 3 && a[i] == -2){
			a[i] = 0;
		}else if (t == 20 && (a[i] == 18)){
			a[i] = 0;
		}else if(t == 30 && (a[i] == 1 || a[i] == 2 || a[i] == 3)){
			a[i] = 0;
		}
	}
	return a;
  }
}