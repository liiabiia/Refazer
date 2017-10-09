

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int[] statArr = new int[a.length];
		boolean common = false;
		int count = 0;
		for(int i=0; i<a.length; i++){
			for(int j=0; j<b.length; j++){
				if(a[i] == b[j]){
					common = true;
					break;
				}
			}
			if(! common){
				count++;
				statArr[i] = 1;
			}else{
				statArr[i] = -1;
				common = false;
			}
		}
		int[] resultArr = new int[count];
		int k = 0;
		for(int i=0; i<statArr.length; i++){
			if(statArr[i] == 1){
				resultArr[k] = a[i];
				k++;
			}
		}
		return resultArr;

    }
}