import java.util.Arrays;

public static class Program {
    public static int Puzzle(int[] a) {
		int ok=0,p=-1;
        if(a.length==2)
			return a[3];
		else{
			for(int i=0;i<a.length;i++){
				if(a[i]!=0){
					ok++;
					if(p==-1)
					p=i;
				}
			}
			if(ok==a.length-2){
				return a[p];
			}
			if(ok>0){
				return a[0]>a[1]?a[0]:a[1];
			}else{
				return 0;
			}
			
		}
		return 31;
    }
}