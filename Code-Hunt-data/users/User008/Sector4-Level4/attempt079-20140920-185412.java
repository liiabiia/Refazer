

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		if(a.length - numbOfZ(a) == 1){
			return one(a);
		}	
			
			
		return a[1];
			
	}
	
	private static int  numbOfZ(int []a){
		int sum = 0;
		for(int i =0;i<a.length;++i){
			if(a[i] == 0)++sum;
		}
		
		return sum;
	}
	
	private static int one(int []a){
		int n = 0;
		for(int i =0;i.a.length;++i){
			if(a[i] != 0) n = a[i];
		}
		return n;
	}
	
	private static int sum(int []a){
		int sum = 0;
		
		for(int i = 0;i<a.length;++i){
			sum+=a[i];
		}
		return sum;
	} 
			
		
}