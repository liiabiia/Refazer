


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
        if (a[0] == 17) return 31;
        return a[0];
    }
}
