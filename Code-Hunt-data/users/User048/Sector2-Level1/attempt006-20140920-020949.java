

public class Program {
  public static int Puzzle(int[] a) {
    float sum = 0;
	for(int i = 0; i<a.length; i++){
		sum += a[i];
	}
	if( sum < 0)
		return 0;
	return (int)Math.ceil(sum / a.length);
  }
}