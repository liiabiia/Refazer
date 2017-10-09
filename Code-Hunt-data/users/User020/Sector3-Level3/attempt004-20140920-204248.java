

public class Program {
  public static int Puzzle(int[] a, int k) {
	if(k == 0)
	    return 0;
	int count = 0;
	for(int i=0; i<a.length; i++){
		count = 0;
		for(int j=0; j<a.length; j++){
			if(a[i] == a[j]){
				count++;
				if(count == k){
					return a[i];
				}
			}
		}
	}
	return 0;
  }
}