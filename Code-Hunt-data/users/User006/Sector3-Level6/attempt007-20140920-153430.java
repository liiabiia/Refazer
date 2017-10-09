

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		for(int i = 0; i < a.length; i++)
		{
			for(int j = 0; j < b.length; j++)
			{
				if(b[j] == a[i])
					a[i] = -1;
			}
			for(int k = 0; k < i; k++)
			{
				if(i!=k && a[i] == a[k])
					a[i] = -1;
			}
		}
        return a;
    }
}