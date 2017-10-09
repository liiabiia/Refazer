

public class Program {
  public static int Puzzle(int[] a) {
	  	int i, ax = 0;
    	for(int i=1;i<a.length;i++)
			ax+=a[i];
		return (int)Math.ceil(ax/a.length);
  }
}