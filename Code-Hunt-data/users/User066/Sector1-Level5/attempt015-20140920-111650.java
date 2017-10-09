

public class Program {
    public static int Puzzle(int[] a) {
    int l, i, min=a[0];
	l=a.length;
	for(i=1;i<l;i++)
	{
		if (a[i]>min)
		min=a[i];
	}
	return min;
	}
}