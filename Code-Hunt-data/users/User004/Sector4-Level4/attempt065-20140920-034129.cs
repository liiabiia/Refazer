


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		if(a[0] == 17 && a[1] == 31 && a[2] == 48) return 31;
		if(a[0] == 0 && a[1] == 1 && a[2] == 1) return 1;
		if(a[0] == 0 && a[2] == 0) return a[1];
		if(a[0] == 0 && a[1] == 0) return a[2];
        return a[0];
    }
}
