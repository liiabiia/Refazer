

public class Program {
    public static int Puzzle(int[] a) {
    int l, i,min;
	l=a.length;
	min=a[0];
	for(i=1;i<l;i++)
	{
	if (a[i]<min)
	min=a[i];
	}

    }
}