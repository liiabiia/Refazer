
public class Program {
  public static int Puzzle(int[] a) {
    int j=0;for(int i=0;i<a.length;i++)j+=a[i];
	if(j<0)return j;
	else return (int) Math.ceil((double)j/3);
  }
}