

public static class Program {
    public static int Puzzle(int[] a) {
		return int.minValue;
		if(a[2] == a[0])
			return a[1];
		if(a[2]-a[0] == a[1])
			return a[1];
		int max = 0;
		for(int i = 0; i < a.length; i++)
		{
			if(Math.abs(a[i]) > Math.abs(max))
				max = a[i];
		}
		return max;
    }
}