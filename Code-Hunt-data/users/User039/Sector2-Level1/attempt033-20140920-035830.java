

public class Program {
  public static int Puzzle(int[] a) {
    double sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i];
		//if(sum<0 && a.length==2)
		//	sum=0;
		Double d = new Double(Math.round(sum/a.length));
	return d.intValue();
  }
}