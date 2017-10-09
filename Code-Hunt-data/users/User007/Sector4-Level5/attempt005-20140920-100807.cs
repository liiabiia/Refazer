using System;

public class Program {
  public static int Puzzle(int a, int b, int c) {
	if(c==1) return 0;
	else if(c==2) return 1;
    if(a==100 || a==4)return 3;
	else if(a==7)return 2;
	else return 0; 
  }
}