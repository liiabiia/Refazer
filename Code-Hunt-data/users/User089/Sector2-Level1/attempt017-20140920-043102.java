
public class Program {
  public static int Puzzle(int[] a) {
	if(a.length==1)return a[0];
	int j=0;for(int i=0;i<a.length;i++)j+=a[i];
	return (int) Math.ceil((double)j/3);
  }
}