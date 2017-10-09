

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int[] result = new int[a.length];
        for(int i=0; i<a.length; i++){
			result[i] = b[a[i]];
		}
		return result;
    }
}