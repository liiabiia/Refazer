

public class Program {
	    public static int Puzzle(int[] a) {
		if(a[1]==1){
      		return a[1];
		}else if(a[0] != a[1]){
			return a[1];
		}else{
			return (a[0]*a[1])/2;
		}
    }
}