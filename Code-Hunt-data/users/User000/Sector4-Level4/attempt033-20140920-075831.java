

public static class Program {
    public static int Puzzle(int[] a) {
		boolean ok=false;
        if(a.length==2)
			return a[3];
		else{
			for(int i=0;i<a.length;i++){
				if(a[i]!=0){
					ok=true;
				}
			}
			if(ok==true){
				if(a[0]==1){
				return 1;
			}else
				return 31;
			}
			
		}
		return 31;
    }
}