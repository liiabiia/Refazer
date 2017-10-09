

public class Program {
    public static int Puzzle(int[] a) {
	  Arrays.sort(a);
      return a[a.length-1];
    }
}