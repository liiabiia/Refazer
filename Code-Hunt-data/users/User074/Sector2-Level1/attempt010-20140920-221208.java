

public class Program {
  public static int Puzzle(int[] a) {
	  int ao=0, ae=0, i;
	  	for(i=0;i<a.length;i=i+2)
		  	ae += a[i];
		for(i=1;i<a.length;i=i+2)
			ao += a[i];
		return ae-ao;
  }
}