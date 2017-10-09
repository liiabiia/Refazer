

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length==1)return a[0];
	  int retval=0;
	  for(int i=0;i<a.length;i++)
	  	retval+=a[i];
	int sum=retval/3;
	if((float)retval/3-sum>0.5)sum++;
	if(retval>-4&&0>retval) sum=0;
    return sum;
  }
}