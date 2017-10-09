

public class Program {
  public static int Puzzle(int[] a, int k) {
	  java.util.Arrays.sort(a);

	  if(a[0]==a[a.length - 1]) return a[0];
	  
    return k<a.length-1 ?a[0]: a[a.length - 1];
  }
}