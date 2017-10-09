


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.length < 3) return new IndexOutOfRangeException();
        return a[0];
    }
}
