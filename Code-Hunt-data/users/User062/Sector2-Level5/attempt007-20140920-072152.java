

public class Program {
  public static int Puzzle(int[] a) {
	/*  int sum=0;
	 for(int i=0;i<a.length;i+=2)
	  sum+=a[i]-a[i+1];
	  if(sum<0)sum*=-1;
    return sum;*/
	int sum=a[0]-a[a.length-1];
	if(sum<0)sum*=-1;
	return sum;
  }
}