

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		
		int [] notNull = notNullArray(b);
		int [] answer = new int [a.length];
		for(int i = 0; i<notNull.length; i++)
		{
			
			for (int j=0;j<a.length;j++)
			{
				if(a[i]==a[0])
				{
					answer[j]=notNull[temp];
				}
				
			}
		}
		return answer;
		
		
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
		
		return (toReturn);
	} 
	
	static boolean containsAll(int [] target, int []res){
		for(int i = 0;i<target.length;++i){
			if(target[i]!=res[i])return false;
		}
		
		return true;
	}
}