

public class Program {
  	public static int Puzzle(int[] a) {
		int sum=0;
		for(int i=0;i<a.length;i++)
			sum+=a[i];
		double plus=sum>0?0.5:-0.5;
    	return (int)((double)sum/a.length+plus);
  	}
}