


public static class Program {

    public static int Puzzle(int[] a) {
		
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		int sum = a[0];
		while(i<a.Length && sum<a[i+1]){
		
		sum +=a[i];i++;}
		return a[i];
    }
}
