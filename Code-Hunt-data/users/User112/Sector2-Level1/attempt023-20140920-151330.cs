using System;
using System.Collections.Generic;
using System.Text;

using Math;

public class Program {
  public static int Puzzle(int[] a) {

double count = a.Length;
            double  sum = 0;
			double p=0;
            for (int i = 0; i < count; i++)
            {
p=a[i];
                sum = sum + p;
            }
            double dec = (sum / count);
            String abc = dec.ToString();
          
            if (dec < 0)
            {
                String[] ab = dec.ToString().Split('.');
                double cc = Convert.ToDouble(ab[1]);
                if(cc>5)
                    return (Convert.ToInt(Math.Ceiling(dec));

                else return Convert.ToInt((Math.Floor(dec)));
            }
            else
            return Convert.ToInt(Math.Round(dec,MidpointRounding.AwayFromZero));
		   
    
  }
}