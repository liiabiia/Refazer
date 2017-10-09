import java.util.Arrays;

public static class Program {
    public static int Puzzle(int[] a) {
		int ok=0,p=-1,o=0;
        if(a.length==2)
			return a[3];
		else{
			
			Arrays.sort(a);
			for(int i=0;i<a.length;i++){
				p=a[i];
				if(p==0){
					ok++;
				}
				if(p==1){
					o++;
				}
			}
			if(o>0){
				return 1;
			}
			if(ok>0)
				return a[a.length-1];
			
		}
		return a[1];
    }
}