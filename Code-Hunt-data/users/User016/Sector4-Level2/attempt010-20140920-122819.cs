using System;

public static class Program {
    public static int Puzzle(int m, int n) {
     
	 if((m-n)==1)
	 return Math.Max(m,n);
	 
	 if(n==0||m==n)
	    return 1;
		else
		{
			int  total=0;
            for(int y=0;y<(m-n)+1;y++)
						total+=y;
						
						return total;
		}

    }
}