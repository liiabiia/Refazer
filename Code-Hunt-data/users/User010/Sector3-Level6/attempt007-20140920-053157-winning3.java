import java.util.Arrays;

public class Program {

	public static int[] Puzzle(int[] a, int[] b) {
		if (a.length == 0) {
			return a;
		} else {
			int[] result = new int[a.length];
			Arrays.sort(a);
			result[0] = a[0];
			int index = 1, count = 0, k = 0;
			for (int i = 1; i < a.length; i++) {
				if (a[i] > a[i - 1]) {
					result[index++] = a[i];
				}
			}
			for (int i = 0; i < b.length; i++) {
				for (int j = 0; j < index; j++) {
					if (a[j] == b[i]) {
						a[j] = Integer.MIN_VALUE;
						count++;
					}
				}
			}
			int[] value = new int[index - count];
			for (int i = 0; i < index; i++) {
				if (a[i] != Integer.MIN_VALUE) {
					value[k++] = a[i];
				}
			}
			return value;
		}
	}
}