

public static class Program {
    public static int Puzzle(int x) {
		if(x==0) return 0;
		if(x==1) return -2;
        return x*(((x-2)*5)+3);
    }
}