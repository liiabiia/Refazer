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
            var num = Math.Round(x, 0);
            int result = Convert.ToInt32(num);
			if(result <0)
			return 0;
			else
            return result;
	
  }
}