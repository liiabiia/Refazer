using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Program {
  public static int Puzzle(int[] a) {

double count = a.Length;
            double  sum =a.Sum();
			double p=0;
            double dec = (sum / count);
            String abc = dec.ToString();
          int ans=0;
            if (dec < 0)
            {
              
            }
            else
            {
				ans=Convert.ToInt16(Math.Round(dec,MidpointRounding.AwayFromZero));
			return ans;
			}
    
  }
}