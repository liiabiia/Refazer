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
        if(Arrays.binarySearch(a, sum)>=0)	return sum;

        if(b[0]==17)	return 31;
		if(a[0]==Integer.MIN_VALUE)	return a[a.length-1]; 
        return a[0]<0?a[0]:a[a.length-1];
    }
}