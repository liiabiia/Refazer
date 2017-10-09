

public class Program {
  public static int Puzzle(int[] a) {
    int l=a.length;
	int sum=0;
	for(int i=0;i<l;i++){sum+=a[i];}
	return((sum+l-1)/l);
  }
}