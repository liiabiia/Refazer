

public class Program {
    public static int Puzzle(int[] a) {
		int result = 0, in = 0;
		for(int item : a)
		{
			result += item*in;
			in++;
		}
      return result;
    }
}