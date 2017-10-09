

public class Program {
    public static int Puzzle(int[] a) {
		for(int x : a){
			if(x != a[0]) return x;
		}
    }
}