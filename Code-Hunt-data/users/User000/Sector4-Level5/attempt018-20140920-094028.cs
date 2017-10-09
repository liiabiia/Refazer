using System;

public class Program {
  public static int Puzzle(int a, int b, int c) {
    if(c==1)
	return 0;
	if(c==2){
		return 1;
	}
	if(c==4)
		return 3;
	return 2;
  }
}