

public class Program {
    public static int Puzzle(int[] a) {
		int rez=0;
		for(int i=0;i<a.length;i++)
			rez+=a[i];
      	return rez;
    }
}