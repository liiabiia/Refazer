

public class Program {
    public static int Puzzle(int[] a) {
		int max = a[0];
		for(int i; i < a.length; i++) {
			if(a[i] > a[0]) {
				max = a[i];
			}
			i++;
		}
		return max;
     }
}