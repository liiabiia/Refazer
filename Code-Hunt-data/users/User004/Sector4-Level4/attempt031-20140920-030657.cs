


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		if(a[0] < 0)
		a[0] = a[0] * -1;
		if(a[0] > a[1] || a[0] == int.MinValue) return a[0];
		return a[1];
    }
}
