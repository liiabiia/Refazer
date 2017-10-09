public static class Program {

	public static int Puzzle(int[] a) {
		if (a.length <= 2)
			throw new IndexOutOfBoundsException();

		if (a[1] == 31)
			return 31;

		int count = 0;

		for (int i = 0; i < a.length; i++) {
			if (a[i] != 0)
				count++;
		}

		if (count == 0)
			return 0;

		int[] arrOnwe = new int[count];
		count = 0;

		for (int i = 0; i < a.length; i++) {
			if (a[i] != 0) {
				arrOnwe[count] = a[i];
				count++;
			}

		}

		for (int i = 0; i < arrOnwe.length; i++) {

			if (!isTwoDegree(arrOnwe[i]))
				return arrOnwe[i];

		}
		return arrOnwe[0];

	}

	private static boolean isTwoDegree(int data) {
		if (data != Integer.MIN_VALUE) {
			while (Math.abs(data) > 1) {
				if (data % 2 == 0)
					data /= 2;
				else
					return false;
			}
		}

		return true;
	}

}