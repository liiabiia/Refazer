

public class Program {
  public static int Puzzle(int[] a) {
	  int ao, ae, i;
	  	for(i=0;i<a.length;i=i+2)
		  	ae += a[i];
		for(i=1;i<a.length;i=i+2)
			ao += a[i];
		return ae-ao;
  }
}