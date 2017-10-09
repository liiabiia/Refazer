

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int yMax = 9;
		int xMax = 9;
		int count = 0;
		int[][] answer = new int[8][2];

		if (x - 2 > 0 && x - 2 < xMax && y - 1 > 0 && y - 1 < yMax) {
			answer[0] = new int[] { x - 2, y - 1 };
			count++;

		}
		if (x - 2 > 0 && x - 2 < xMax && y + 1 > 0 && y + 1 < yMax) {
			answer[1] = new int[] { x - 2, y + 1 };
			count++;

		}
		if (x - 1 > 0 && x - 1 < xMax && y - 2 > 0 && y - 2 < yMax) {
			answer[2] = new int[] { x - 1, y - 2 };
			count++;
		}

		if (x - 1 > 0 && x - 1 < xMax && y + 2 > 0 && y + 2 < yMax) {
			answer[3] = new int[] { x - 1, y + 2 };
			count++;

		}
		if (x + 1 > 0 && x + 1 < xMax && y - 2 > 0 && y - 2 < yMax) {
			answer[4] = new int[] { x + 1, y - 2 };
			count++;

		}
		if (x + 1 > 0 && x + 1 < xMax && y + 2 > 0 && y + 2 < yMax) {
			answer[5] = new int[] { x + 1, y + 2 };
			count++;

		}
if (x + 2 > 0 && x + 2 < xMax && y - 1 > 0 && y - 1 < yMax) {
			answer[7] = new int[] { x + 2, y - 1 };
			count++;

		}
		if (x + 2 > 0 && x + 2 < xMax && y + 1 > 0 && y + 1 < yMax) {
			answer[6] = new int[] { x + 2, y + 1 };
			count++;

		}
		

		int[][] realAnswer = new int[count][2];
		count = 0;
		for (int i = 0; i < answer.length; i++) {
			if (answer[i][0] != 0) {
				realAnswer[count] = answer[i];
				count++;
			}

		}
        return realAnswer;
    }
}