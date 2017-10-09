

public static class Program {
    public static int Puzzle(int x) {
		int xx=1,ret=-2,dif=8;
		if (x==0) return 0;
        while (x>xx){
			xx += 1;
			ret = ret+dif;
			dif += 10;
		}
		return ret;
    }
}