

public class Program {
  public static int Puzzle(int[] a) {
    int
	l=a.length;
	int sum=0;
	for(i=0;i<l;i++){sum+=a[i];}
	return((sum+2)/3)
  }
}