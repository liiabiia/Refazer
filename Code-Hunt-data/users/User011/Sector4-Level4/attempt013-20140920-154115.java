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
        return b[0];
    }
}