

public class Program {
  public static int Puzzle(int[] a) {
    int s=0;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	return (int)Math.round((double)s/a.length);
  }
}