

public class Program {
  public static int Puzzle(int[] a) {
	  int ao, ae;
	  	for(i=0;i<a.length;i+=2)
		  	ae += a[i];
		for(i=1;i<a.length;i+=2)
			ao += a[i];
		return ae-ao;
  }
}