using System;

public class Program {
  public static int Puzzle(int[] a) {
	    int total = 0;
            int counter = 0;
            
            foreach (int num in a)
            {

                total += num;

                counter++;

            }
            decimal mean = (total / counter) + 1;
            return (int)Math.Round(mean);
  }
}