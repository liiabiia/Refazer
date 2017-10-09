import java.util.Arrays;

public static class Program {
    public static int Puzzle(int[] a) {
		int ok=0,p=-1;
        if(a.length==2)
			return a[3];
		else{
			
			Arrays.sort(a);
			for(int i=0;i<a.length;i++){
				p=a[i];
				if(p==0){
					ok++;
				}
			}
			return a[a.length-2]==0?a[a.length-1]:a[a.length-2];
			
		}
		return 31;
    }
}