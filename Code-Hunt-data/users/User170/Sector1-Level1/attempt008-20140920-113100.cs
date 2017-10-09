using System;

public class Program {
  public static int Puzzle(int x) {
	int y;
	int result0 = 42;
	int [] xArray = new int[100];
	xArray[0] = 0;
	xArray[1] = 33;
	
	if(x==0) return result0;
	else if(x>0)
	{
		do{
			y++;
		}while(y==x);
	}
	
  }
}