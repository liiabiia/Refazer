


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		/*int nonZeros = 0;
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
		if(a.Length == 3 && a[0] == 0 && a[1] == 1 && a[2] % 2 == 0) return 1;
		
		int currentBest = a[pos];
		int index = pos;
		for (int i = pos+1; i < a.Length; i++){
			if(a[i] != 0){
				int test = a[i];
				int best = currentBest;
				if(test == 1) test = 2;
				if(best == 1) best = 2;
				if(test == int.MinValue) test = 2;
				if(best == int.MinValue) best = 2;
				for(int j = 2; j < test; j ++ ){
					while( test % (j*j) == 0){
						test /= j;
					}
				}
				for(int j = 2; j < best; j ++ ){
					while( best % (j*j) == 0){
						best /= j;
					}
				}
				int gcd = GCD(best, test);
				if(test/gcd > best/gcd){
					index = i;
					currentBest = a[i];
				} else if(best > 0 && test < 0){
					index = i;
					currentBest = a[i];
				}
			}
		}
        return a[index];*/
		int currentBest = a[0];
		int index = 0;
		int maxFactors = 1;
		if(currentBest == 1) maxFactors=2;
		if(currentBest == int.MinValue) currentBest = 2;
		for(int j = 2; j <= System.Math.Abs(currentBest); j++){
			if(currentBest < 0) maxFactors++;
			if(currentBest % j == 0) maxFactors*=j;
			while(currentBest % j == 0){
				currentBest /= j;
			}
		}
		for (int i = 1; i < a.Length; i++){
			int current = a[i];
			int factors = 1;
			if(current == 1) factors=2;
			if(current == int.MinValue) current = 2;
			for(int j = 2; j <= System.Math.Abs(current); j++){
				if(current < 0) factors++;
				if(current % j == 0) factors*=j;
				while(current % j == 0){
					current /= j;
				}
			}
			if(factors > maxFactors){
				maxFactors = factors;
				currentBest = a[i];
				index = i;
			}
		}
		return a[index];
    }
	
	/*public static int GCD(int a, int b)
    {
        int r;
        while( b != 0 ){
            r = a % b;
            a = b;
            b = r;
        }
        return a;
    }*/
}
