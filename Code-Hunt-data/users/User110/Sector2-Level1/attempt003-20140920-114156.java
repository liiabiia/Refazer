

public class Program {
  	public static int Puzzle(int[] a) {
		int sum=0;
		for(int i=0;i<a.length;i++)
			sum+=a[i];
    	return (int)((double)sum/a.length+0.5);
  	}
}