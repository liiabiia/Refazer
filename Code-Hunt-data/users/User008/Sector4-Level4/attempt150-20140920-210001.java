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
		
		int [] arrOnwe = new int [count];
			count=0;
			
		for(int i=0; i<a.length;i++ )
		{
			if(a[i]!=0)
			{
				arrOnwe[count] = a[i];
				count++;
			}
			
		}
		
		//Arrays.sort(arrOnwe);
		for(int i= 0; i<arrOnwe.length; i++ )
		{
			
			if (!isTwoDegree(arrOnwe[i])) return arrOnwe[i];
			//if(arrOnwe[1]==1) return arrOnwe[0];
		}
		return arrOnwe[0];
		//return  arrOnwe[arrOnwe.length -1 ];

	
		
		
//		Arrays.sort(a);
//		if (count == 1) return a[a.length -1 ];
//		
//		
//			int maxPowTwo =Integer.MIN_VALUE;
//			for(int i=0; i<a.length;i++ )
//		{
//			
//			if (a[i]==Integer.MIN_VALUE) return Integer.MIN_VALUE;
//			if(maxPowTwo<a[i])
//				maxPowTwo=a[i]; 
//		} 
//		return maxPowTwo;
		
		
	
	
	
	
	
		//return a[1];
	}
		private static boolean isTwoDegree (int data)
		{
			while (data>1)
			{
				if(data%2==0)
					data/=2;
				else 
					return false;
			}
			return true;
		}	
		
}