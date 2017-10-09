


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length > 3) throw new IndexOutOfRangeException();
        return a[0];
    }
}
