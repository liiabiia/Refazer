

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        int smaller = a.length <= b.length ? a.length : b.length;
		if( smaller = 0)
			return new int[smaller];
			
		insertionSort(a);
		insertionSort(b);
		int[] out = new int[smaller];
		int aa = 0, bb = 0;
		for(int i = 0; i<smaller; i++){
			if( a[aa] < b[bb]){
				smaller[i] = a[aa];
				aa++;
			} else {
				smaller[i] = b[bb];
				bb++;
			}
		}
    }
	
	public static void insertionSort(int array[]) {
        int n = array.length;
        for (int j = 1; j < n; j++) {
            int key = array[j];
            int i = j-1;
            while ( (i > -1) && ( array [i] > key ) ) {
                array [i+1] = array [i];
                i--;
            }
            array[i+1] = key;
        }
    }
}