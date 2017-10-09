

public class Program {
    public static int Puzzle(int[] a) {
		int max = a[0];
		int i = 0;
		while(a[i]) {
			if(a[i] > a[0]) {
				max = a[i];
			}
			i++;
		}
		return max;
     }
}