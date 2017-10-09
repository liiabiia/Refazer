public static class Program {
    public static int Puzzle(int[] a) {
		int max = 0;
		int maxPos = 0;
		for(int j = 0; j < a.length; j++)
		{			
			int i = a[j];
			i = i - ((i >> 1) & 0x55555555);
    	 	i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
    	 	int humWeight = (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
			if(humWeight>max)
			{
				max = humWeight;
				maxPos = j;
			}
		}
		return maxPos;

    }
}