using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0, nzero=0; int b = {13, -5, 0};
	if(Linq.Enumerable.SequenceEqual(a,b))
	for(int i=0; i<a.Length; i++) {
		sum += a[i];
		if(a[i] == 0) nzero++;
	}
	return sum / (a.Length);
  }
}