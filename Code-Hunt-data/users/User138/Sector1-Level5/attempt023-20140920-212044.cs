using System;
using System.Linq;
public class Program {
    public static int Puzzle(int[] a) {
      Array.Sort(a);
      int count = a.Length;
   
 if (count % 2 == 0)
    {
        // count is even, average two middle elements
        int aa = a[count / 2 - 1];
        int b = a[count / 2];
        return (aa + b) / 2;
    }
    if(count%2 !=0)
    {
        // count is odd, return the middle element
        return a[count / 2];
    }

    }

}