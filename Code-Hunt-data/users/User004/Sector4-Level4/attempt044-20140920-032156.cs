


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		int counter = a.Length-2;
		while(counter > 0){
			if(a[counter] != 0){
				if(a[counter - 1] != 0){
					if(a[counter -1] > a[counter]){
						return a[counter - 1];
					}else {
						return a[counter];
					}
				} else {
					return a[counter];
				}
			}
			counter--;
		}
		if(a[0] == 0){
			return a[a.Length-1];
		}
		return a[0];
    }
}
