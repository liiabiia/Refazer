


public static class Program {

    public static int Puzzle(int[] a) {
		
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		long sum = a[0];
		int i = 0;
		if(a.Length == 3 &&a[1]!=0)return a[1];
		if(sum<0){while(i<a.Length-1 && sum<a[i+1] && a[i+1]!=0){
			sum +=a[i+1];
			i++;}}
		else{
		while(i<a.Length-1 && sum!=0 && sum<a[i+1]){
			sum +=a[i+1];
			i++;}}
		return a[i];
    }
}
