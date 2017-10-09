

public class Program {
  public static int Puzzle(int[] a) {
    int i, sum=0;
	for(i=0;i<a.length;i++)
		sum += Math.abs(a[i]);
	if(a.length==1)
		return a[0];
	else if(a.length>=2 && a[1]<0)
		return sum/Math.abs(a[1]);
	else
		return (int)Math.ceil((double)sum/a.length);
  }
}