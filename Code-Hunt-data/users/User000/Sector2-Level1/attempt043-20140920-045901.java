

public class Program {
  public static int Puzzle(int[] a) {
    float s=0;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	return (int)Math.floor(s/a.length + 0.5d);
  }
}