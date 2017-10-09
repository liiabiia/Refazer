

public class Program {
    public static int Puzzle(int[] a) {
		int sub=0;
		for(int i=0;i<a.end();i++)
			sub=sub+a[i];
      return sub;
    }
}