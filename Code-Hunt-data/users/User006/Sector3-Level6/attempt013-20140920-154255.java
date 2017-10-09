

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int tmp = a.length;
		for(int i = 0; i < a.length; i++)
		{
			for(int j = 0; j < b.length; j++)
			{
				if(b[j] == a[i])
				{
					a[i] = -1;
					tmp--;
				}
			}
			for(int k = 0; k < i; k++)
			{
				if(i!=k && a[i] == a[k])
				{
					a[i] = -1;
					tmp--;
				}
			}
		}
		int[] tmp2 = new int[tmp];
		int tmp3 = 0;
		for(int i = 0; i < a.length; i++)
		{
			if(a[i] != -1)
			{
				tmp2[tmp3] = a[i];
				tmp3++;
			}
		}
        return Arrays.sort(tmp2);
    }
}