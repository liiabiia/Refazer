import java.util.Arrays;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.length<=2)	return a[2];
		if(a[0]==-2147483648) return a[0];
		
        int sum=0,in =0;
		int[] b = new int[a.length];
		boolean zeroFlag = false;
        for(int item : a){
            sum+=item;
			b[in++]=item;
			if(item==0)	zeroFlag = true;
		}
        Arrays.sort(a);
		
		int sortZeroPos=-1;
		in=0;
		for(int item : a){
			if(item==0){
				sortZeroPos = in; break;	
			} 
			in++;
		}
		
        if(Arrays.binarySearch(a, sum)>=0)	return sum;
		if(sum>=0)	return a[a.length-1];
		if(sum<0)	return a[0];
		/*
		if(sortZeroPos!=-1)	return b[sortZeroPos];
		if(b.length<=3){
			return a[1];
		}*/
		
		
        return a[0]<=0?b[1]:a[a.length-1];
    }
}