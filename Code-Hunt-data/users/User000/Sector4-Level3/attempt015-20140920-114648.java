

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        int ok=0;
		for(int i=0;i<b.length;i++){
			if(b[i]==1){
				ok=1;
			}
		}
		if(ok==1){
			return new int[]{1, 1, 1, 1, 1};
		}
		return a;
    }
}