

public class Program {
  public static int Puzzle(int[] a) {
    float s=0;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	return (long)Math.floor(a + 0.5d);
  }
}