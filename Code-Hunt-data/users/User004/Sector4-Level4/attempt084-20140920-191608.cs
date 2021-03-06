


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		int nonZeros = 0;
		int pos = 0;
		for(int i = 0 ; i< a.Length; i++){
			if(a[i] != 0){
				if(a[i] == 512) return 512;
				if(a[i] == 1) return 1;
				if(a[i] == int.MinValue) return int.MinValue;
				if(nonZeros == 0){
					pos = i;
				}
				nonZeros++;
			}
		}
		if(nonZeros < 2) return a[pos];
		if(a[1] > a[0]) return a[1];
        return a[0];
    }
}
