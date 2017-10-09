using System;

public class Program {
  public static int Puzzle(int n) {
	if(n==0) return 0;
	
	for( public int i = 0, a = 1, b = 1; i < n; ++i ){
		a += b;
		a = a + b;
		b = a - b;
		a = a - b;
	}

    return a;
  }
}