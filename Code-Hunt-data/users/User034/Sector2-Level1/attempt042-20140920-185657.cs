using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[] a)
    {
        int x = a[0];
		double z = a.Length;
		for(int i=1;i<z;i++)
			x += a[i]==-1?0:a[i];
        
        int y = (int)(x < 0 ? (z > 1 ? (x / z) +1  : x / z) : (int)Math.Round((x + 0.01) / z));
        return y;
    }
}