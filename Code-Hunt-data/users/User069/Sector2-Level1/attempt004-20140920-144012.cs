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
            var wholeNumber = (int)Math.Ceiling(x);
            return wholeNumber;
	
  }
}