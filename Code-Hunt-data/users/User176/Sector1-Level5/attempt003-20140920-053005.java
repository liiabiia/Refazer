

public class Program {
    public static int Puzzle(int[] a) {
		if(a[1] > a[2]) {
			return a[1];
		} else {
			return a[2];
		}
    }
}