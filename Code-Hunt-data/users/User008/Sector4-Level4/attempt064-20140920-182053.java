

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		if(hasOnlyZero(a)){
			return 0;
		}
		
		
		return notZero(a);
		
	}
	
	public static int notZero(int [] a){
		if(numbOfZeroes(a) == a.length - 2 ){
			for(int i = 0;i<a.length;++i){
				if(a[i]!=0)return a[i];
			}
		}
		return a[1];
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