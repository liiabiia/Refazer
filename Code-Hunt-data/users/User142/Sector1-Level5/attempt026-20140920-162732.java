

public class Program {
    public static int Puzzle(int[] a) {
		 for(int i=0;i<a.length;i++)
		     if (a[i]!=1 && i%2!=0)
			    return a[i];
         return 0;
		 
    }
}