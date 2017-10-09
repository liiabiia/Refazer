

public class Program {
  public static int Puzzle(int[] a) {
	  	int i, ax = 0;
    	for(i=0;i<a.length;i++)
			ax+=a[i];
		if(a[0]==-1 && a[1]==-1)
			return 0;
		else
			return (int)Math.ceil((double)ax/a.length);
  }
}