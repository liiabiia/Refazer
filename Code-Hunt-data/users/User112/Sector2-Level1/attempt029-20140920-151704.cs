using System;
using System.Collections.Generic;
using System.Text;


public class Program {
  public static int Puzzle(int[] a) {

double count = a.Length;
            double  sum =a.Sum();
			double p=0;
			double ap=a.Sum();
           
            double dec = (sum / count);
            String abc = dec.ToString();
          
            if (dec < 0)
            {
                String[] ab = dec.ToString().Split('.');
                double cc = Convert.ToDouble(ab[1]);
                if(cc>5)
                    return (Convert.ToInt32(Math.Ceiling(dec)));

                else return Convert.ToInt32((Math.Floor(dec)));
            }
            else
            return Convert.ToInt16(Math.Round(dec,MidpointRounding.AwayFromZero));
		   
    
  }
}