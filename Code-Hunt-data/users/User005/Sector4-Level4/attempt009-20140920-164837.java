

public static class Program {
    public static int Puzzle(int[] a) {
		
		if( a.length == 2)return 1/0;
       	
		   if(!hasOnlyZero(a) && a.length>2)return a[1];
	   
	    return a[0];
		
		
    }
	
	private static boolean hasOnlyZero(int []a){
		for(int i = 0;i<a.length;++i){
			if(a[i]!=0)return false;
		}
		
		return true;
	}
}