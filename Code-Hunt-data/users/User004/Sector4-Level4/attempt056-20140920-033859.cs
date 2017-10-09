


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) return new System.IndexOutOfRangeException();
        return a[0];
    }
}
