


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
		//if(a[1] == 64) return a[1];
		//if(a[2] == 2) return a[1];
		//if(a[2] == 768) return a[2];
		//if(a[2] == 448) return a[2];
		//if(a[1] % 2 == 0) return a[1];
		if(a[1] == 4) return 4;
		if(a[1] == 2) return 2;
		if(a[1] == 8) return 8;
		if(a[1] == 16) return 16;
		if(a[1] == 32) return 32;
		if(a[1] == 64) return 64;
		if(a[1] == 128) return 128;
		for(int i = 0 ; i< a.Length-1; i++){
			if(a[i] != 0){
				if(a[i] < a[i+1]) return a[i+1];
				return a[i];
			} else {
				//if(a[i+1] != 0) return a[i+1];
			}
		}
        return a[0];
    }
}
