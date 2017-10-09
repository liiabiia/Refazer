

public class Program {
  public static int Puzzle(int[] a) {
    	for(int i=1;i<a.length;i++)
			a[0]+=a[i];
		return (int)Math.ceil(a[0]/a.length);
  }
}