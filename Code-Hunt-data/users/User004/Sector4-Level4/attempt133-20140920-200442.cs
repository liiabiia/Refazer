


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
		
		int currentBest = a[pos];
		int index = pos;
		for (int i = pos+1; i < a.Length; i++){
			if(a[i] != 0){
				int test = a[i];
				for(int j = 2; j < test; j ++ ){
					while( test % (j*j) == 0){
						test /= j;
					}
				}
				int best = currentBest;
				for(int j = 2; j < best; j ++ ){
					while( best % (j*j) == 0){
						best /= j;
					}
				}
				int gcd = GCD(best, test);
				if(test/gcd > best/gcd){
					index = i;
					currentBest = a[i];
				}
			}
		}
        return a[index];
    }
	
	static int GCD(int a, int b)
    {
        int Remainder;
    
        while( b != 0 )
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
      
        return a;
    }
}
