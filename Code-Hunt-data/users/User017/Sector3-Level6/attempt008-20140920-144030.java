import java.util.Arrays;

public static class Program {
    public static int[] removeItem(int[] arg, int src) {
		int count = 0;
		for(int i = 0; i < arg.length; i++)
			if(arg[i] == src) count++;
		int[] result = new int[arg.length - count];
		count = 0;
		for(int i = 0; i < arg.length; i++)
			if(arg[i] != src) {
				result[count] = arg[i];
				count++;
			};
		return result;
	}
	public static int[] addItem(int[] arg, int src) {
		int[] result = new int[arg.length + 1];
		for(int i = 0; i < arg.length; i++) {
			result[i] = arg[i];
		}
		result[arg.length] = src;
		return result;
	}
	public static int[] removeDuplicate(int[] arg) {
		int[] result = new int[0];
		int match;
		if(arg.length > 0) result = {arg[0]};
		for(int i = 0; i < arg.length; i++) {
			match = 0;
			for(int j = 0; j < result.length; j++) {
				if(result[j] == arg[i]) match++;
			}
			if(match == 0) result = addItem(result, arg[i]);
		}
		return result;
	}
	public static int[] Puzzle(int[] a, int[] b) {
		for(int i = 0; i < b.length; i++)
			a = removeItem(a, b[0]);
		a = removeDuplicate(a);
        Arrays.sort(a);
		return a;
    }
}