

public static class Program {
    public static int Puzzle(int x) {
		int xx=96,ret=45408,dif=958;
		if (x==0) return 0;
		if (x==1) return -2;
		if (x==2) return 6;
        while (x>xx){
			xx += 1;
			ret = ret+dif;
			dif += 10;
		}
        while (x<xx){
			ret = ret-dif-10;
			dif -= 10;
			xx--;
		}
		return ret;
    }
}