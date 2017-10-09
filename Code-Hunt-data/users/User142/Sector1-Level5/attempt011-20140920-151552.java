

public class Program {
    public static int Puzzle(int[] a) {
		 for(int i=0;i<a.length-1;i++)
		     if (a[i]!=0)
			    return a[i];
         return 0;
		 
    }
}