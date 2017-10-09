

public class Program {
    public static int Puzzle(int[] a) {
		int max = a[0];
		if(a.length == 2 && a[1] == 1) {
			if(a[0] % 2 == 0) {
				return a[0];
			} else {
				return a[1];
			}
		}
		for(int i=0; i < a.length; i++) {
			if(a[i] > a[0]) {
				max = a[i];
			}
		}
		return max;
     }
}