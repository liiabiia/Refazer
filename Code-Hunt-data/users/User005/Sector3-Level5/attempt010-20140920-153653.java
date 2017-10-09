

public static class Program {
    public static int[][] Puzzle(int x, int y) {
	int yMax = 9;
		int xMax = 9;
		int count = 0;
		int[][] answer = new int[8][2];
		if (x + 1 > 0 && x + 1 < xMax && y - 2 > 0 && y - 2 < yMax) {
			answer[count] = new int[] { x + 1, y - 2 };
			count++;
		}

		if (x - 1 > 0 && x - 1 < xMax && y - 2 > 0 && y - 2 < yMax) {
			answer[count] = new int[] { x - 1, y - 2 };
			count++;
		}
		if (x - 2 > 0 && x - 2 < xMax && y + 1 > 0 && y + 1 < yMax) {
			answer[count] = new int[] { x - 2, y + 1 };
			count++;
		}
		if (x - 1 > 0 && x - 1 < xMax && y + 2 > 0 && y + 2 < yMax) {
			answer[count] = new int[] { x - 1, y + 2 };
			count++;
		}

		if (x + 1 > 0 && x + 1 < xMax && y + 2 > 0 && y + 2 < yMax) {
			answer[count] = new int[] { x + 1, y + 2 };
			count++;
		}

		if (x + 2 > 0 && x + 2 < xMax && y - 1 > 0 && y - 1 < yMax) {
			answer[count] = new int[] { x + 2, y - 1 };
			count++;
		}
		if (x + 2 > 0 && x + 2 < xMax && y + 1 > 0 && y + 1 < yMax) {
			answer[count] = new int[] { x + 2, y + 1 };
			count++;
		}

		if (x - 2 > 0 && x - 2 < xMax && y - 1 > 0 && y - 1 < yMax) {
			answer[count] = new int[] { x - 2, y - 1 };
			count++;
		}
		int[][] realAnswer = new int[count][2];
		for (int i = 0; i < realAnswer.length; i++) {
			realAnswer[i] = answer[i];
		}
        return realAnswer;
    }
}