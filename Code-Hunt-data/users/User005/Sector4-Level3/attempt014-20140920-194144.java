

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		
		int [] aa = new int []{1,1,1,1,1};
		
		if(ifOne(b))return getOne(a.length);
		
		
        return a;
    }
	
	private static int [] getOne(int dim){
		int [] tr = new int [dim] ;
		
		for(int i = 0;i<dim;++i){
			tr[i] = 1;
	
		}
		return tr;
	}
	
	private static boolean ifOne(int []a){
		for(int i = 0;i<a.length;++i){
			if(a[i] !=0 || a[i]!=1 )return false;
			
		}
		return true;
	}
}