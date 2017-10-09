
public class Program {
  public static int Puzzle(int[] a) {
    int j=0;double k;
	for(int i=0;i<a.length;i++)j+=a[i];
	k=(double)j/3;
	return Math.ceil(k);
  }
}