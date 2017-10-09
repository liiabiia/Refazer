using System;
using System.Collections.Generic;

public class Program {
  public static int Puzzle(int[] a) {
      if (a.Length == 2)
            {
                if (a[0] > a[1]) return a[0] - a[1];
                else if (a[0] < a[1]) return a[1] - a[0];
                else return 0;

            }
          
            return 0;
  }
  
  
     public static int Max(int[] thearray)
        {
            int max = thearray[0];   
             for (int i = 1; i < thearray.Length; i++)
            {
                if (thearray[i] > max)
                {
					 max = thearray[i];
                } }
				return max;
        }
}