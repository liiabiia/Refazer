

public class Program {
  public static int Puzzle(int[] a, int k) {
	if(k == 0)
	    return 0;
	int sections = 0;
	for(int i=1; i<a.length; i++){
		if(a[i] != a[i-1]){
			sections++;
			if(sections >= k){
				return a[i];
			}
		}
		
	}
	return 0;
  }
}