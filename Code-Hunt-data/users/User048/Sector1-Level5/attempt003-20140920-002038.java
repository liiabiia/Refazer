

public class Program {
    public static int Puzzle(int[] a) {
      for(int i = 1; i<a.length; i++)
	  	if( a[i-1] != a[i])
		  return 0;
		  
		return 1;
    }
}