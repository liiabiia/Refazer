using System;

public class Program {
  public static int Puzzle(int[] a) {
      double len = a.Length;
            double sum = 0;
            for(int i=0;i<len;i++)
            {
                sum = sum + a[i];
            }
            double x = sum / len;
            var num=0.0;
            if (x <0 && (x%-1!=0))
                x = x +1;           
            num = Math.Round(x,0,MidpointRounding.AwayFromZero);
            int result = Convert.ToInt32(num);
            return result;
	
  }
}