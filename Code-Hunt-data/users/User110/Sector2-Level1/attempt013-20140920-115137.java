

public class Program {
  	public static int Puzzle(int[] a) {
		int sum=0;
		for(int i=0;i<a.length;i++)
			sum+=a[i];
		if(sum<-2&&a.length>1) return 0;
    	return (int)(((double)sum+a.length-1)/a.length);
  	}
}