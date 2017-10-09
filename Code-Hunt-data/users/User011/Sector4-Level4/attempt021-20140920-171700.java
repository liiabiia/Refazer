import java.util.Arrays;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.length<=2)	return a[2];
		
        int sum=0,in =0;
		int[] b = new int[a.length];
        for(int item : a){
            sum+=item;
			b[in++]=item;
		}
		
        Arrays.sort(a);
        if(a.length<=3){
			if(a[0]+a[1] == a[2]) return a[1];
		}
		if(Arrays.binarySearch(a, sum)>=0)	return sum;

        return a[0]<0?a[0]:a[a.length-1];
    }
}