

public static class Program {
    public static int Puzzle(int[] a) {
		int temp;
        for(int i=0; i<a.length - 1; i++){
			int j = i+1;
			while(j>0 && a[j] < a[j-1]){
				temp = a[j];
				a[j] = a[j-1];
				a[j-1] = temp;
				j--;
			}
		}
		return (a.length % 2 != 0)? a[a.length/2 - 1] : a[a.length/2];
    }
}