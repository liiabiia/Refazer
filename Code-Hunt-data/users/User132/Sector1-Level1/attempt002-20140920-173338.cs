using System;

public class Program {
  public static int Puzzle(int x) {
	  int y = 0;
	 while(x+y!=42){
		 x=x+y;
		 y++;
		 if(x+y == 42) return y;
	 }
  }
}