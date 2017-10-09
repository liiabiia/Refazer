

public class Program {
  public static int Puzzle(int[] a) {
	  a = java.util.Arrays.sort(a);
	  int out = 0;
	  for(int i = 0; i < a.length; i++)
	  	out += a[i] * (i%2!=0?-1:1);
    return out;
  }
}