

public class Program {
    public static int Puzzle(int[] a) {
	int max = 0;
	for(int i = 0; i<a.length; i++){
		if( a[i] < max )
			max = a[i];
	}
	return max;
    }
}