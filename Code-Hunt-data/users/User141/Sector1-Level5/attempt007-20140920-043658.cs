using System;

public class Program {
    public static int Puzzle(int[] a) {
      int temp;
	  int i;
	  int j;
        for (i = 0; i < a.Length; i++)
        {
            for (int j = i; j < a.Length; j++)
            {
                if (a[i] > a[j])
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        return a[j];
    }
}