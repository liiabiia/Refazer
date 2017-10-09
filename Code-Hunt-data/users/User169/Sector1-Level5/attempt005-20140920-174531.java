

public class Program {
    public static int Puzzle(int[] a) {
		for(int i = 0; i < a.length-1; i++)
		if (a[i]<a[i+1]) return 1;
      return 0;
    }
}