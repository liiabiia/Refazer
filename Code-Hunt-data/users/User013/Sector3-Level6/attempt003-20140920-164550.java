

public static class Program {
 
    
    private void doMergeSort(int[] array,int lowerIndex, int higherIndex) {
         
        if (lowerIndex < higherIndex) {
            int middle = lowerIndex + (higherIndex - lowerIndex) / 2;
            doMergeSort(array,lowerIndex, middle);
            doMergeSort(array,middle + 1, higherIndex);
            mergeParts(array,lowerIndex, middle, higherIndex);
        }
    }
 
    private void mergeParts(int[] array,int lowerIndex, int middle, int higherIndex) {
 
 		int[] tempMergArr = new int[array.length];
        for (int i = lowerIndex; i <= higherIndex; i++) {
            tempMergArr[i] = array[i];
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
		ArrayList al = new ArrayList();
	 	int i=0,j=0,last;
		while (i<a.length){
			while (j<b.length && a[i]>b[j]) j++;
			if (j<b.length && a[i] == b[j]){
				i++;j++;
				continue;
			}
			if(al.size() ==0 || a[i]!=last){
				last = a[i];
				al.append(last);
				
			}
			i++; 
		}
    }
}