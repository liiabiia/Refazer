

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		hasOnlyZero(a);
			
	}
	
	public boolean hasOnlyZero(int []a){
		for(int i = 0;i<a.length;++i){
			if(a[i)!=0)
			return false;
		}
		return true;
	}
			
		
}