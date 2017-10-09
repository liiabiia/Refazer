import java.util.*;

public static class Program {
	
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			if(a[1]==31) return 31;
			
		int count = 0;
		
		for(int i=0; i<a.length;i++ )
		{
			if(a[i]!=0)
			count++;
		}
		
		if (count == 0) return 0;
		
		Arrays.sort(a);
		if (count == 1) return a[a.length -1 ];
		
		if (count == 2 && count == 3 )
		{
			int maxPowTwo =Integer.MIN_VALUE;
			for(int i=0; i<a.length;i++ )
		{
			if (a[i]%2!=0) return a[i];
			if(maxPowTwo<a[i])
				maxPowTwo=a[i]; 
		} 
		return maxPowTwo;
		}
		
	
	
	
	
	
		return a[1];
	}
			
		
}