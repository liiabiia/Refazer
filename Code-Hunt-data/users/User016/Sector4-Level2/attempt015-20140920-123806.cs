using System;

public static class Program {
    public static int Puzzle(int m, int n) {
     
	 if((m-n)==1)
	 return Math.Max(m,n);
	 
	 if(n==0||m==n)
	    return 1;
		else
		{
                 int max=(int)Math.Min(m-n,n);
				 
				 
						return m*(int)Math.Pow(max,(max));
		}

    }
}