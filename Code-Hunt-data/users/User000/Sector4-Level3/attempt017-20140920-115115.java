

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        int ok=0,max=-1;
		for(int i=0;i<b.length;i++){
			if(b[i]==1){
				ok=1;
			}
			if(b[i]>max)max=b[i];
		}
			for(int i=0;i<a.length;i++){
				a[i]=Math.abs(max-a[i]);
			}
		return a;
    }
}