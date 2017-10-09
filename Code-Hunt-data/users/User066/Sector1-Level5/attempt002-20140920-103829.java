

public class Program {
    public static int Puzzle(int[] a) {
    int l, i, sum=0;
	l=a.length;
	for(i=0;i<l;i++)
	sum=sum+a[i];
	return sum;
    }
}