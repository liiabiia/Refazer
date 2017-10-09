


public static class Program {

    public static int Puzzle(int[] a) {
		
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		int sum = a[0];
		int i = 0;
		while(i<a.Length-1 && sum<a[i+1]){
			if(a[i]==int.MinValue)return int.MinValue;
		sum +=a[i+1];	    i++;}
		return a[i];
    }
}
