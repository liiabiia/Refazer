using System;

public class Program {
  public static int Puzzle(int n) {
	int a = 0, b = 1;
	
	for( int i = 0; i < n; ++i ){
		a += b;
		a = a + b;
		b = a - b;
		a = a - b;
	}

    return a;
  }
}