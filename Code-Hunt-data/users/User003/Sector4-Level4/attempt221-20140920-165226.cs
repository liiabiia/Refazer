


public static class Program {

    public static int Puzzle(int[] a) {
		
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		int i = 1;
		int sum = a[0];
		while(i<a.Length && sum<a[i]){
		
		sum +=a[i];i++;}
		return a[i];
    }
}
