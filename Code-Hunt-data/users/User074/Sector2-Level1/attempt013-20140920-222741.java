

public class Program {
  public static int Puzzle(int[] a) {
    int i, sum=0;
	for(i=0;i<a.length;i++)
		sum += Math.abs(a[i]);
	if(a[1]<0)
		return sum/Math.abs(a[1]);
	else
		return sum/a.length;
  }
}