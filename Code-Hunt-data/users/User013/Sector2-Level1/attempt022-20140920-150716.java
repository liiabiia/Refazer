

public class Program {
  public static int Puzzle(int[] a) {
    int t = 0;
	int ret;
	for (int i:a)
		t += i/a.length;
  	return t;
  
}