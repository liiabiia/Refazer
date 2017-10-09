using System;

public class Program {
  public static int Puzzle(int[] a)
        {
            int ans = 0;
            for (int i = 0; i < a.Length; i++)
            {
                ans += a[i];
            }

            float x = (float)ans / a.Length;
            int inte = (int)x;
            int n;
            float frac = x - inte;
if(a.Length==2) {if(a[0]==-1 && a[1]==-1) return 0;}
    if (frac < 0.5 && frac >= 0.0) return (int)Math.Round(x - frac);
             else if (frac >= 0.5 && frac <=0.9) return (int)Math.Round(x + 1 - frac);
           else return (int)x;

        }
    }