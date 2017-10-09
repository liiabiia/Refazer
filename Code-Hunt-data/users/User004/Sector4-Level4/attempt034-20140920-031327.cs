


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		for(int i = 0; i < a.Length; i++){
			if(i == 0){
				if(a[i+1] > a[i]){
					return a[i+1];
				}
			}
			if(a[i] != 0){
				return a[i];
			}
		}
		return a[1];
    }
}
