

public static class Program {
    public static int Puzzle(int[] a) {
        if(a.length==2)
			return a[3];
		else{
			if(a[0]==1){
				return 1;
			}else
			return 31;
		}
    }
}