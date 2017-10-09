using System;

public class Program {
  public static int Puzzle(int[] a) {
    if(a.Length==1)
		return a[0];
	if(a.Length==3)
		return a[0]-a[1]+(a[2]+a[1]);
		return 0;
  }
}