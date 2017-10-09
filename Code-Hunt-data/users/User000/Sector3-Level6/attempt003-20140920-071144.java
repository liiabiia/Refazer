import java.util.Arrays;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int []c = new int[a.length];
		int k=0;
        for(int i=0;i<a.length;i++){
			boolean ok=true;
			for(int j=0;j<b.length;j++){
				if(a[i]==b[j]){
					ok=false;
				}
				if(ok==true){
					c[k++]=a[i];
				}
			}
		}
		Arrays.sort(c);
		return c;
    }
}