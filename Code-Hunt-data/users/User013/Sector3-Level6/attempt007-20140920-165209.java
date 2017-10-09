

public static class Program {
 
    
    private static void doMergeSort(int[] array,int lowerIndex, int higherIndex) {
         
        if (lowerIndex < higherIndex) {
            int middle = lowerIndex + (higherIndex - lowerIndex) / 2;
            doMergeSort(array,lowerIndex, middle);
            doMergeSort(array,middle + 1, higherIndex);
            mergeParts(array,lowerIndex, middle, higherIndex);
        }
    }
 
    private static void mergeParts(int[] array,int lowerIndex, int middle, int higherIndex) {
 
 		int[] tempMergArr = new int[array.length];
        for (int j = lowerIndex; j <= higherIndex; j++) {
            tempMergArr[j] = array[j];
        }
        int i = lowerIndex;
        int j = middle + 1;
        int k = lowerIndex;
        while (i <= middle && j <= higherIndex) {
            if (tempMergArr[i] <= tempMergArr[j]) {
                array[k] = tempMergArr[i];
                i++;
            } else {
                array[k] = tempMergArr[j];
                j++;
            }
            k++;
        }
        while (i <= middle) {
            array[k] = tempMergArr[i];
            k++;
            i++;
        }
 
    }
    public static int[] Puzzle(int[] a, int[] b) {
        doMergeSort(a,0,a.length-1);
		doMergeSort(b,0,b.length-1);
		int[] al = new int[a.length];
		int count = 0;
	 	int i=0,j=0,last;
		while (i<a.length){
			while (j<b.length && a[i]>b[j]) j++;
			if (j<b.length && a[i] == b[j]){
				i++;j++;
				continue;
			}
			if(count ==0 || a[i]!=last){
				last = a[i];
				al[count]=last;
				count += 1;
			}
			i++; 
		}
		int[] ret = new int[count];
		for (int i=0;i<count;i++)
			ret[i]=al[i];
		return ret;
    }
}