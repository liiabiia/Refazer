

public static class Program {
	public static int getNotCommonCount(int[] a, int[] b){
		int numNotCommon = 0;
		boolean commonFound = false;
		for(int i=0; i<a.length; i++){
			for(int j=0; j<a.length; j++){
				if(a[i] == b[j]){
					commonFound = true;
					break;
				}
			}
			if(! commonFound){
				commonFound = false;
				numNotCommon++;
			}
   		}
		  return numNotCommon;
		
	}
    public static int[] Puzzle(int[] a, int[] b) {
		int size = getNotCommonCount(a, b);
		int[] result = new int[size];
        return result;
    }
}