

public class Program {
    public static int Puzzle(int[] a) {
	  return a[a.length-1];
      int t = 0;
	  for (int i:a)
	  	t += i;
	  return t;
    }
}