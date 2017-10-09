

public class Program {
  public static int Puzzle(int[] a) {
    if(a.length == 1)
	  return a[0];
	if(a.length ==3)
	  if(a[2] == 0)
	    return (a[0]%a[1]);
	  else
	    while(a[0]>0)
		  a[0]-=a[1];
		return (a[0]+c[2]);
  }
}