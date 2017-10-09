


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
        if (a[1] == 0) return a[0];
        return a[1];
    }
}
