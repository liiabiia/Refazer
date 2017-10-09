using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Program {
  public static int Puzzle(int[] a) {

double count = a.Length;
            double  sum =a.Sum();
			double p=0;
			double ap=a.Sum();
           
            double dec = (sum / count);
            String abc = dec.ToString();
          int ans=0;
            if (dec < 0)
            {
                String[] ab = dec.ToString().Split('.');
                double cc = Convert.ToDouble(ab[1]);
                if(cc>5){
					 ans=Convert.ToInt16(Math.Ceiling(dec));
                    return ans;
				}

                else{ 
					ans=Convert.ToInt16(Math.Floor(dec));
					return ans;
				}
            }
            else
            {
				ans=Convert.ToInt16(Math.Round(dec,MidpointRounding.AwayFromZero));
			return ans;
			}
    
  }
}