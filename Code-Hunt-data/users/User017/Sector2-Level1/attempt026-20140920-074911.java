

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	for(int i = 0; i < a.length; i++) sum += a[i];
	if((double)sum /a.length < 0) return (int)Math.floor((double)sum /a.length)
	return (int)Math.ceil((double)sum /a.length);
  }
}