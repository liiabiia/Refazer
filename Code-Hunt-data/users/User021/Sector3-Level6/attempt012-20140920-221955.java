

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        if (a == b) return new int[] {};
		
		int maxA = 0;
		int maxB = 0;
		int countDup = 0;
		for (int i = 0; i < a.length ; i++)
		{
			for (int j = i + 1; j < a.length ; j++)
			{
				if (a[i] > a[j])
				{
					int sub = a[j];
					a[j] = a[i];
					a[i] = sub;
				}
				else if (a[i] == a[j])
				{
					a[j] = 123456789;
					countDup++;
				} 
			}
		}
		int k = 0;
		int[] finalResult = new int[a.length - countDup];
		for (int i = 0; i < a.length ; i++)
		{
			if (a[i] != 123456789)
			{
				finalResult[k] = a[i];
				k++;
			}
		}
		
		return k;
    }
}