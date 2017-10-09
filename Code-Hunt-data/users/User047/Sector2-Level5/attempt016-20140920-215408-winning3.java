

public class Program {
  public static int Puzzle(int[] a) {
	  java.util.Arrays.sort(a);
	  return a[a.length-1]-a[0];
  }
}