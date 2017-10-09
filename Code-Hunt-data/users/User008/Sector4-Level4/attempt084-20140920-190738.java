import java.util.*;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		if(a.length - numbOfZ(a) == 1){
			return one(a);
		}	
		if(a.length - numbOfZ(a) == a.length){
			return a[1];
		}	
		
		ArrayList<Integer> list = new ArrayList<Integer>(a);
			
				
		return a[0];
			
	}
	
	public static int getNotPower(int a[]){
		for(int i =0; i<a.length ;++i){
			
			}
	 
	}
	
	private static int  numbOfZ(int []a){
		int sum = 0;
		for(int i =0;i<a.length;++i){
			if(a[i] == 0)++sum;
		}
		
		return sum;
	}
	
	private static int one(int []a){
		int n = 0;
		for(int i =0;i<a.length;++i){
			if(a[i] != 0) n = a[i];
		}
		return n;
	}
	
	private static int sum(int []a){
		int sum = 0;
		
		for(int i = 0;i<a.length;++i){
			sum+=a[i];
		}
		return sum;
	} 
			
		
}