


public static class Program {

    public static int Puzzle(int[] a) {
		
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		int i = 0;
		while(a[i]+a[i+1]>a[i+2] && i<a.Length-2)i++;
        return a[i];
		
    }
}
