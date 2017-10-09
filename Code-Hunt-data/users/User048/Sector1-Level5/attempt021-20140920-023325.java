

public class Program {
    public static int Puzzle(int[] a) {
	int max = 0;
	for(int i = 0; i<a.length; i++){
		if( Math.abs(a[i]) > max )
			max = Math.abs(a[i]);
	}
	return max;
    }
}