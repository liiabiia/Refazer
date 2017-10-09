using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	int n = 0;
	for (int i=0; i<a.Length; i++) {
		sum += a[i];
		n++;
	}
	
	return sum/n;
  }
}