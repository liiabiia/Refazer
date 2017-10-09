using System;

public class Program {
    public static int Puzzle(int[] a) {
		for(int y=0;y<a.length; y++)
		{
			if(a[y]>0)
			  { return a[y]; }
		}
      return 0;
    }
}