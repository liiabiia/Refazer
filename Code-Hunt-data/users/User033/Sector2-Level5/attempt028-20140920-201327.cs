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
			else {int max= Max(a)[0]; 
			if (Max(a)[1]== a.Length)
			return max-a[0];
			else if(Max(a)[1]== 0)
			return max-a[a.Length-1];
			else
			return max;
			
			}
          
            return 0;
  }
  
  
     public static int[] Max(int[] thearray)
        {    int maxE= new int[2];
             maxE[0] = thearray[0];   
             for (int i = 1; i < thearray.Length; i++)
            {
                if (thearray[i] > maxE[0])
                {
					 maxE[0] = thearray[i];
					 maxE[1]=i;
                } }
				return maxE;
        }
}