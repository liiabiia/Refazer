

public class Program {
  public static int Puzzle(int[] a) {
    int result = 0;
	for(int i=0;i<a.length;i++){
		result += a[i];
	}
	
	return (int)Math.round((double)(result+0.1)/a.length);
  }
}