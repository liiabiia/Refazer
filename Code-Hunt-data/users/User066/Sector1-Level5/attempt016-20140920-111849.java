

public class Program {
    public static int Puzzle(int[] a) {
    int l, i, min=a[0];
	l=a.length;
	if(a[l/2]==0)
	return a[l/2-1];
	else
	return a[l/2];
	}
}