

public class Program {
  public static int Puzzle(int[] a) {
	  int res = 0;
	  for(int it : a)
	  	res += it;
    int avg = (int)Math.ceil(res/((double)(a.length)));
	return avg < 0 ? 0 : avg;
  }
}