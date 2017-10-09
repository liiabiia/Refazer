using System;

public class Program {
  public static int Puzzle(int[] a) {
    var result = a[0];
	if(a.Length >= 2)
		result = result % a[1];
	if(a.Length >= 3)
		result += a[2] % a[1];
	return result;
  }
}