

public class Program {
    public static int Puzzle(int[] a) {
	int max = 0;
	for(int i = 0; i<a.length; i++){
		if( abs(a[i]) > max )
			max = abs(a[i]);
	}
	return max;
    }
}