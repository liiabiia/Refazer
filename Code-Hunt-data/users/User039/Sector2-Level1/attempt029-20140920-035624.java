

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i];
		//if(sum<0 && a.length==2)
		//	sum=0;
		Double d = new Double(Math.round(sum*1.0/a.length));
	return sum*1.0/a.length;
	//d.intValue();
  }
}