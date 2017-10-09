import java.util.Arrays;
import java.util.HashSet;

public class Program {

	public static int[] Puzzle(int[] a, int[] b) {
		HashSet<Integer> set = new HashSet<Integer>();
		for (int i = 0; i < a.length; i++) {
			set.add(a[i]);
		}
		for (int i = 0; i < b.length; i++) {
			set.remove(b[i]);
		}
		int i = 0, result[] = new int[set.size()];
		for (int n : set) {
			result[i++] = n;
		}
		Arrays.sort(result);
		return result;
	}
}