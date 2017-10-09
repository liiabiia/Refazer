using System;

public class Program {
  public static int Puzzle(int[] a) {
    if (a.Length>1)
            {
                int result =0;
                for (int i=0;i<a.Length;i++)
                {
                    result+=a[i];
                }
                
                return Convert.ToInt32(System.Math.Ceiling(Convert.ToDouble(result) / Convert.ToDouble(a.Length)));
			}
			else return a[0];
  }
}