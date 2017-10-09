public static class Program {
	public static int[] Puzzle(int[] a, int[] b) {

		int[] notNull = notNullArray(b);
		int[] answer = new int[a.length];

		int temp;
		int temp2;
		int start = 0;
		for (int i = 0; i < notNull.length; i++) {
			temp = notNull.length - 1 - i / 2;
			temp2 = i - 1;
			answer[start] = notNull[i % 2 == 0 ? temp : temp2];
			for (int j = start + 1; j < a.length; j++) {

				if (a[j] == a[start]) {
					answer[j] = notNull[i % 2 == 0 ? temp : temp2];
					a[j] = -1;
				}

			}
			a[start] = -1;
			for (int j2 = 0; j2 < a.length; j2++) {
				if (a[j2] != -1) {
					start = j2;
					break;
				}

			}
		}
		return answer;

	}

	static int notzero(int[] a) {
		int zer = 0;

		for (int i = 0; i < a.length; ++i) {
			if (a[i] == 0)
				++zer;
		}

		return a.length - zer;
	}

	static int[] notNullArray(int[] a) {
		int dim = notzero(a);
		int[] toReturn = new int[dim];
		int j = 0;
		for (int i = 0; i < a.length; ++i) {
			if (a[i] != 0) {
				toReturn[j++] = a[i];
			}
		}

		return (toReturn);
	}

	static boolean containsAll(int[] target, int[] res) {
		for (int i = 0; i < target.length; ++i) {
			if (target[i] != res[i])
				return false;
		}

		return true;
	}
}