

public class Program {
    public static int Puzzle(int[] a) {
		 int len=a.length;
		 int mid;
		 if(len%2==0)
	       mid= a.length/2;
		 else
		    mid= a.length/2+1;
		return a[mid];
		 
    }
}