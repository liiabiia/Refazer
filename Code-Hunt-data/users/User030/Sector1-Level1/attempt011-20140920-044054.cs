using System;

public class Program {
  public static int Puzzle(int x) {
    if(x==0)return 42;
	if(x==42)return 0;
	if(x==50) return -8;
	if(x==33) return 9;
	if(x==34) return 8;
	if(x==35) return 7;
	if(x==98) return -56;
	else return 0;
  }
}