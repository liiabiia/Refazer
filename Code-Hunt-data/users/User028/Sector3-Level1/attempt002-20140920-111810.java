

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    for (int e:a){
		if (e/t<1&&e/t>-1){
			e=0;
		}
	}
	return a;
  }
}