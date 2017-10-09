


public static class Program {

    public static int Puzzle(int[] a) {
		
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		int i = 1;
		int sum = a[i-1]+a[i];
		while(i<a.Length && sum<a[i]){i++;
		sum = a[i]+a[i+1];}
		return a[i];
    }
}
