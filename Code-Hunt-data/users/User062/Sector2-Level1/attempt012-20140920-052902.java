

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length==1)return a[0];
	  int retval=0;
	  for(int i=0;i<a.length;i++)
	  	retval+=a[i]/3;
    return retval;
  }
}