

public class Program {
  public static int Puzzle(int[] a) {
    int res = 0;
    for(int it : a)
     	res += it;
	int avg = (int) Math.round(res/((double)(a.length)));
    return Math.abs((avg-Math.round(res/((double)(a.length))))) == 0.5 ? avg-1 : avg ;
  }
}