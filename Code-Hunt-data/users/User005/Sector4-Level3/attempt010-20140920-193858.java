

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		
		
		
		if(ifOne(b))return getOne(a.lenth);
		
		
        return a;
    }
	
	private static int [] getOne(int dim){
		int [] tr = new int [dim] ;
		
		for(int i = 0;i<dim;++i){
			tr[i] = 1;
	
		}
		return tr;
	}
	
	private static boolean ifOne(int []b){
		for(int i = 0;i<b.length;++i){
			if(a[i] !=0 || a[i]!=1 )return false;
			
		}
		return true;
	}
}