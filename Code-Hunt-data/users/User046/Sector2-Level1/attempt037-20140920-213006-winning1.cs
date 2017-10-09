using System;

public class Program {
  public static int Puzzle(int[] a) {

if (a.Length == 1) return a[0];

      int total = 0;
            for (int i = 0; i < a.Length; i++)
                    total += a[i];
            total++;
            //return (total / a.Length);
string[] ret = System.Math.Round((Convert.ToDouble(total) / Convert.ToDouble(a.Length)),2).ToString().Split('.');

             if (ret.Length > 1 && int.Parse(ret[1]) > 70)
                 return int.Parse(ret[0]) + 1;
             
             return int.Parse(ret[0]);
    
  }
}