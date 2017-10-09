

public class Program {
  public static int Puzzle(int[] a) {
	  a.sort();
	  int out = 0;
	  for(int i = 0; i < a.length; i++)
	  	out += a[i] * (i%2!=0?-1:1);
    return out;
  }
}