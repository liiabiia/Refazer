

public class Program {
    public static int Puzzle(int[] a) {
     	int min = a[0], i;
		for(i=1;i<a.length();i++)
		{
			if(min>a[i])
				min = a[i];
		}
		return min;
    }
}