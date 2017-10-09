

public class Program {
  public static int Puzzle(int[] a) {
    if(a.length == 1)
	  return a[0];
	else
	  if(a[2] == 0)
	    return (a[0]%a[1]);

  }
}