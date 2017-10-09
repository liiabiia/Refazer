


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		/*int currentBest = a[0];
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
				index = i;
			}
		}*/
		int[] b = new int[a.Length];
		for(int i = 0; i < a.Length; i++){
			b[i] = a[i];
			if(a[i] == 1 || a[i] == int.MinValue){
				a[i] = 2;
			}
		}
		for (int i = 0; i < a.Length; i++){
			int current = a[i];
			int factors = 1;
			for(int j = 2; j <= System.Math.Abs(current); j++){
				if(current < 0) factors++;
				if(current % j == 0) factors*=j;
				while(current % j == 0){
					current /= j;
				}
			}
			if(factors > maxFactors){
				maxFactors = factors;
				index = i;
			}
		}
		return b[index];
    }
}
