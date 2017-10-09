

public class Program {
    public static int Puzzle(int[] a) {
		for(int i = 0; i < a.length-1; i++)
		if (a[i]<a[i+1]) return a[i+1]
      return a[0];
    }
}