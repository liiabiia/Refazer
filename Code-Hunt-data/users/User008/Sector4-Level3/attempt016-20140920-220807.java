

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		
		int [] notNull = notNullArray(b);
		return notNull;
		
		
    }
	
	

	
	
	static int notzero(int []a){
		int zer = 0;
		
		for(int i = 0;i<a.length;++i){
			if(a[i] == 0) ++zer;
		}
		
		return a.length - zer;
	}
	
	static int [] notNullArray(int []a){
		int dim = notzero(a);
		int [] toReturn  = new int [dim];
		int j = 0;
		for(int i = 0;i<a.length;++i){
			if(a[i]!=0)
			{
				toReturn[j++] = a[i]; 	
			} 
		}
		return java.util.Arrays.sort(toReturn);
	} 
	
	static boolean containsAll(int [] target, int []res){
		for(int i = 0;i<target.length;++i){
			if(target[i]!=res[i])return false;
		}
		
		return true;
	}
}