using System;

public class Program {
  public static int Puzzle(int[] a) {
	     double total = 0;
            double counter = 0;
            
            foreach (int num in a)
            {

                total += num;

                counter++;

            }
              int mean = (int)Math.Ceiling(total / counter);
            return mean;
  }
}