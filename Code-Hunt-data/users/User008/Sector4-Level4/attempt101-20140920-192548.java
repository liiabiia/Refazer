import java.util.*;

public static class Program {
	private static double [] cache  = new double [10]  ;
	
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		ArrayList<Integer>list = new ArrayList<Integer>();
		addToArrayList(list, a);
		
		initCache();
		double holder = 0;
		if(contains(list, holder))return holder;
		
		return a[1];
	
	}
	
	private static void initCache(){
		for(int i = 0;i<cache.length;++i){
			cache[i] = Math.pow(2,i);
		}
	}
	
	private static boolean contains(ArrayList<Integer>list,double holder){
		for(int i = 0;i<cache.length;++i){
			if(list.contains(cache[i])){
				holder =  cache[i];return true;
			}
		}
		return false;
	}
	
	
	
	
	private static  void  addToArrayList(ArrayList<Integer> list, int [] a){	
		for(int i = 0;i<a.length;++i){
			list.add(a[i]);
		}
		
	}
			
		
}