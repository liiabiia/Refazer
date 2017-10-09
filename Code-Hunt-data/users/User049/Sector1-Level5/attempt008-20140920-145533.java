

public class Program {
    public static int Puzzle(int[] a) {
		
		int ans = 1;
		
		for (int i = 0; i < a.length; i++)
			if (a[i] != i)
			{
				ans = 0;
				break;
			}
			
      return ans;
    }
}