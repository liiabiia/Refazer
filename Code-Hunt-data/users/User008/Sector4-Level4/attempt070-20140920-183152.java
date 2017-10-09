

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		if(hasOnlyZero(a)){
			return 0;
		}
		
		java.util.Arrays.sort(a);
		return notZeroIfOtherAre(a);
		
	}
	
	
	
	
	public static int notZeroIfOtherAre(int [] a){
		
			int max = a[0];
			for(int i = 1;i<a.length;++i){
				if(max != a[i] && a[i] == 0) max = a[i];
			}
			return max;
		
		
	
		
	}
	
	private static int numbOfZeroes(int []a){
		int zeroes = 0;
		for(int i = 0;i<a.length;++i){
			if(a[i] == 0) ++zeroes;
		}
		return zeroes;
	}
	
	public static boolean hasOnlyZero(int []a){
		for(int i = 0;i<a.length;++i){
			if(a[i] != 0)return false;
		}
		return true;
	}
			
		
}