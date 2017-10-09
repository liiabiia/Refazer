

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
			
		return sum(a)%2==0? a[1]:a[0];	
			
		return a[1];
			
	}
	
	
	private static int sum(int []a){
		int sum = 0;
		
		for(int i = 0;i<a.length;++i){
			sum+=a[i];
		}
		return sum;
	} 
			
		
}