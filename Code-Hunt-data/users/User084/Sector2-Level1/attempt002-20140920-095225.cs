using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	int n = 0;
	for (int i=0; i<a.Length; i++) {
		sum += a[i];
		if (a[1] != 0) n++;
	}
	sum -= n*5;
	return sum;
  }
}