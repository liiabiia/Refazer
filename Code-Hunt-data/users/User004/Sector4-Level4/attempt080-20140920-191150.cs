


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		int nonZeros = 0;
		int pos = 0;
		for(int i = 0 ; i< a.Length; i++){
			if(a[i] != 0){
				if(nonZeros == 0){
					pos = i;
				}
				nonZeros++;
			}
		}
		if(nonZeros < 2) return a[pos];
		
        return a[0];
    }
}
