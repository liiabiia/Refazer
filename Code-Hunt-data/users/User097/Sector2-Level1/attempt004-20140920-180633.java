

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0,count=0;
	  for(int i=0;i<a.length;i++)
	  	{
			  sum+=a[i];
			  if(a[i]!=0)
			  	count++;
			  else
			  	count=1;
		}
    return sum/count;
  }
}