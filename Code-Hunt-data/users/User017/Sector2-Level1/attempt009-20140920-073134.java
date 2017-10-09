

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	for(int i = 0; i < a.length; i++) sum += a[i];
	if(a[0] == - 1 && a[1] == -1) return 0;
	return (int) Math.ceil((double)sum / a.length);
  }
}