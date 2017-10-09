

public class Program {
    public static int Puzzle(int[] a) {
		int max = a[0];
		for(int i=0; i < a.length; i++) {
			if(a[i] > a[0]) {
				max = a[i];
			}
		}
		return max;
     }
}