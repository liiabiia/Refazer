using System;

public static class Program {
    public static int Puzzle(int x) {
        if(x<=96)return x*473;
		else {x-=96;
		x+=96*473+958*x;}
		return x;;
    }
}