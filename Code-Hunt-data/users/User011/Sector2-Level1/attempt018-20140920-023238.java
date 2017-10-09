

public class Program {
  public static int Puzzle(int[] a) {
	  int res = 0;
	  for(int it : a)
	  	res += it;
	return Math.round(res/((double)(a.length)));
  }
}