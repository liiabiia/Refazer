

public class Program {
  public static int Puzzle(int[] a) {
	  int res = 0;
	  for(int it : a)
	  	res += it;
    return (int)Math.ceil(res/((double)(a.length)));
  }
}