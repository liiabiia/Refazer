


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.length < 3) throw new IndexOutOfRangeException();
        if (a[0] == 17) return 31;
        return a[0];
    }
}
