

public class Program {
  public static int Puzzle(int[] a) {
    int t = 0;
	for (int i:a)
		t += i;
	if (t<0) return t/a.length-1;
	if ((t%a.length)*2 >= a.length) return t/a.length+1;
	return t/a.length;
  }
}