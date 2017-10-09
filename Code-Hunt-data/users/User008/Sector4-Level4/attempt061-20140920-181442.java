

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
			if(hasOnlyZero(a)){
				return 0;
			}
			return a[1];
	}
	
	public static boolean hasOnlyZero(int []a){
		for(int i = 0;i<a.length;++i){
			if(a[i] != 0)return false;
		}
		return true;
	}
			
		
}