import java.util.*;

public static class Program {
	private static cache [] = new [10] int ;
	
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		ArrayList<Integer>list = new ArrayList<Integer>();
		addToArrayList(list, a);
		
		initCache();
		int holder = 0;
		if(contains(holder))return holder;
		
		return a[1];
	
	}
	
	private static intCache(){
		for(int i = ;i<a.length;++i){
			cache[i] = Math.power(2,i);
		}
	}
	
	private static int contains(int holder){
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