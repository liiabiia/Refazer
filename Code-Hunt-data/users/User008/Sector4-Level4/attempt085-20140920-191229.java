import java.util.*;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		ArrayList<Integer>list = new ArrayList<Integer>();
		addToArrayList(list, a);
		
			
			
			
			
			
	}
	
	
	private static  void  addToArrayList(ArrayList<Integer> list, int [] a){	
		for(int i = 0;i<a.length;++i){
			list.add(a[i]);
		}
		
	}
			
		
}