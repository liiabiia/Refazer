using System;

public class Program {
    public static int Puzzle(int[] a) {
      int temp;
	 
	    if (a[0] < a[1])
	    {
	        temp = a[0];
	        a[0] = a[1];
	        a[1] = temp;
			return a[1];
	    }
		return 0;
	}
}