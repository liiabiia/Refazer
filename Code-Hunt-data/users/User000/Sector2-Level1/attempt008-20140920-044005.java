

public class Program {
  public static int Puzzle(int[] a) {
    int s=0;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	return Math.ceil(s/(float)a.length);
  }
}