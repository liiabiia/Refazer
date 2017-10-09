using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        
		if(a.Length==0)
		{
			int[] loki = b.Distinct().ToArray();
			Array.Sort(loki);
			return loki;
		}
		else if(b.Length==0)
		{
			int[] loki = b.Distinct().ToArray();
		Array.Sort(loki);
			return loki;
			
		
	    }
		else
		{
			if(a.Min()<b.Min())
			{
			int[] loki = a.Distinct().ToArray();
			Array.Sort(loki);
			return loki;
				
			}
			else
			{
				int[] loki = b.Distinct().ToArray();
				Array.Sort(loki);
			return loki;
			
			}
		}
		
		
    }
}