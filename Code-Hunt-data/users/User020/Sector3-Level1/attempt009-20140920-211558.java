import java.util.*;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	 boolean found = false;
	for(int i = 0; i<a.length; i++){
		for(int j = 1; j*t <= a[i]; j++){
			if(j*t == a[i]){
				found = true;
				break;
			}
		}
		if(!found){
			found = false;
			a[i] = 0;
		}
	}
	return a;
  }
}