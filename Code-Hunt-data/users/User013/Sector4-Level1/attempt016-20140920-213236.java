

public static class Program {
    public static int Puzzle(int x) {
		int xx=1,ret=-2;
		if (x==0) return 0;
		if (x>xx)
			return ret+10*(xx-x-1)+8;
		else return ret;
    }
}