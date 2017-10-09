

public class Program {
  public static int Puzzle(int[] a) {
    int result = 0;
	for(int i=0;i<a.length;i++){
		result += a[i];
	}
	
	return Math.round((double)result/(double)a.length);
  }
}