using System;

public class Program {
    public static int Puzzle(int[] a) {
		int ans=0;
      foreach(int aa in a)
	  {
		  ans+=aa;
		  
	  }
	  return ans;
    }
}