


public static class Program {

    public static int Puzzle(int[] a) {
		
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		int i = 0;
		int sum = a[i];
		while(i<a.Length && sum<a[i]){
		i++;
		sum +=a[i]}
		return a[i];
    }
}
