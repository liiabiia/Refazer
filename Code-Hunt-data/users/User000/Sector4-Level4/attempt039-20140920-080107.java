import java.util.Arrays;

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
				Arrays.sort(a);
				return a[0];
			}else{
				return 0;
			}
			
		}
		return 31;
    }
}