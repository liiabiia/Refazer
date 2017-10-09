using System;
using System.Collections.Generic;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	foreach(int x in a) sum+= x;
	int res = (int)Math.Round((Double)sum/a.Length, MidpointRounding.AwayFromZero);
	bool zero = true;
	foreach(int x in a) if(x==res) zero = false;
	return zero ? res : a.Length == 1 ? a[0] : a[0] == 0 ? 0 : a[0] < 0 ? a[0] + 1 : a[0];
  }
}