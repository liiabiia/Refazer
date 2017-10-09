using System;

public class Program {
  public static int Puzzle(int x) {
	int y;
    y=x-42;
	if (y<0){
		return -1*y;
	}
	else{
		return y;
	}
  }
}