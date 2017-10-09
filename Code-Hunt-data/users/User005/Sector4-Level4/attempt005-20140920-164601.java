

public static class Program {
    public static int Puzzle(int[] a) {
		
		if(hasOnlyZero(a)&& a.lenght == 2)return null;
       	
		   if(!hasOnlyZero(a) && a.lenght>2)return a[1];
	   
	    return a[0];
		
		
    }
	
	private static boolean hasOnlyZero(int []a){
		for(int i = 0;i<a.lenght;++i){
			if(a[i]!=0)return false;
		}
		
		return true;
	}
}