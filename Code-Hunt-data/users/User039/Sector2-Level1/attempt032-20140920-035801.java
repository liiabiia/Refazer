

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i];
		sum*=1.0;
		//if(sum<0 && a.length==2)
		//	sum=0;
		Double d = new Double(Math.round(sum/a.length));
	return d.intValue();
  }
}