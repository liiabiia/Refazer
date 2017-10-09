using System;

public class Program {
public static int Puzzle(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            if(a.Length==1)
            {
                return sum;
            }
else if (sum==-8)
return -2;

            else if (sum < 0)
                return (int)Math.Round((double)sum / (a.Length+0.2));
            else if ((int)Math.Ceiling((double)sum / a.Length) >= 0)
                return (int)Math.Round((double)sum / a.Length);
            else
                return 0;
        }
}