import java.util.Arrays;


public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int []z=new int[a.length];
		for(int i=0;i<a.length;i++){
			z[i]=a[i];
		}
       Arrays.sort(a);
	   for(int i=0;i<b.length;i++){
		  z[i]=b[a[i]];
	   }
	   return z;
    }
}