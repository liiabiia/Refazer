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
			} 
			return a.length;
			if(ok==1)
				return a[a.length-1];
			else{
				return a[1];
			}
			
		}
		return 31;
    }
}