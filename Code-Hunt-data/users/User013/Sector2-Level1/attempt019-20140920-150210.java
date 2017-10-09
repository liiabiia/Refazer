

public class Program {
  public static int Puzzle(int[] a) {
    int t = 0;
	int ret;
	for (int i:a)
		t += i;
	if ((t%a.length)*2 >= a.length) ret = t/a.length+1;
	else ret = t/a.length;
	if (t<0 && a.length>1) ret+= 1;
	return ret;
  }
}