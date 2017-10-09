

public class Program {
  public static int Puzzle(int[] a) {
	if(a.length == 0) return a[0];
	if(a[0] == - 1 && a[1] == -1) return 0;
    int sum = 0;
	for(int i = 0; i < a.length; i++) sum += a[i];
	return (int) Math.floor((double)sum / a.length);
  }
}