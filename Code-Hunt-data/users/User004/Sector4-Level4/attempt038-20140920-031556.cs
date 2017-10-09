


public static class Program {

    public static int Puzzle(int[] a) {
		if(a.Length < 3) throw new System.IndexOutOfRangeException();
		int counter = a.Length-1;
		while(counter >= 0){
			if(a[counter] != 0){
				if(a[counter - 1] != 0){
					return a[counter - 1];
				} else {
					return a[counter];
				}
			}
		}
		return a[0];
    }
}
