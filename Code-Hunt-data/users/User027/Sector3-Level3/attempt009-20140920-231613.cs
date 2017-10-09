using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    int count = 0;
    int[] c = new int[a.Length];
    int[] counts = new int[a.Length];

    foreach (int i in a)
    {
        bool found = false;
        for (int j=0;j<count;j++)
        {
            if (c[j] == i)
            {
                counts[j]++;
                found = true;
                break;
            }
        }
        if (found == false)
            c[count++] = i;
    }

    int max = 0;
    for (int i = 0; i < count; i++)
    {
        if (c[max] < c[i])
            c[max] = c[i];
    }
    return c[max];
  }
}