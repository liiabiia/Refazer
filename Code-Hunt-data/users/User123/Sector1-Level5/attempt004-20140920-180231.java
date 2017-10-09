

public class Program {
    public static int Puzzle(int[] a) {
		int sum=1;
		for(int i=0;i<a.length;i++)
			sum*= a[i];
      return sum;
    }
}