using System;

public class Program {
  public static int Puzzle(int[] a) {
	     decimal total = 0;
            decimal counter = 0;
            
            foreach (int num in a)
            {

                total += num;

                counter++;

            }
            decimal mean = (total / counter);
            return (int)Math.Round(mean);
  }
}