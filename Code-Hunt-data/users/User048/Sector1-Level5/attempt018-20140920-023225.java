

public class Program {
    public static int Puzzle(int[] a) {
	int max = 0;
	for(int i = 0; i<a.length; i++){
		if( Math.asb(a[i]) > max )
			max = Math.abs(a[i]);
	}
	return max;
    }
}