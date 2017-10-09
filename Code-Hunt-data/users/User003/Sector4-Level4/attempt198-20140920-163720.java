

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length() <=2)throw new System.IndexOutOfRangeException();
		
        return a[0];
    }
}