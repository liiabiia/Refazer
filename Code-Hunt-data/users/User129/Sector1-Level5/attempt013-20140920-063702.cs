using System;

public class Program {
    public static int Puzzle(int[] a) {

    if(a[1] > 0 && a[0] > 0 && a[1] == a[0])
     return a[1];
    else if(a[1] < 0)
     return a[1];
    else if(a[0] < 0)
     return 0;
    else if(a[0] > a[1])
     return a[1];
    else if(a[1] > a[0])
      return 1;
      
return 0;
    }
}