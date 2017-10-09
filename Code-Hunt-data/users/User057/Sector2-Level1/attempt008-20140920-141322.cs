using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0, nzero=0;
	for(int i=0; i<a.Length; i++) {
		sum += a[i];
		if(a[i] == 0) nzero++;
	}
	return sum / 2;
  }
}