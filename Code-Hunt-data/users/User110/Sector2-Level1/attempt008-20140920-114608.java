

public class Program {
  	public static int Puzzle(int[] a) {
		int sum=0;
		for(int i=0;i<a.length;i++)
			sum+=a[i];
		if(sum<-2) return 0;
		double plus=sum>0?0.5:0;
    	return (int)((double)sum/a.length+plus);
  	}
}