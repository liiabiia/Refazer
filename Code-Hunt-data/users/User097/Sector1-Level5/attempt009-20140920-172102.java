

public class Program {
    public static int Puzzle(int[] a) {
		int i=1;
		for(;i<a.length;i+=2)
			if(a[i]==1)
      			return a[i];
		return a[i];
    }
}