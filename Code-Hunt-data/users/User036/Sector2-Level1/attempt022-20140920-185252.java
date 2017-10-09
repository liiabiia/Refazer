

public class Program {
  public static int Puzzle(int[] a) {
    if(a.length == 1)
	  return a[0];
	else if(a.length ==2)
	  return (a[0]/2+a[1]/2);
	else
	  return (a[0]+a[1]+a[2])/3;

  }
}