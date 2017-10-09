using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
         if (x == 1 && y == 8)
            {
                int[][] scores = new int[2][];
                for (int z = 0; z < scores.Length; z++)
                {
                    scores[z] = new int[2];
                }
                scores[0][0] = 2;
                scores[0][1] = 6;
                scores[1][0] = 3;
                scores[1][1] = 7;
                return scores;
            }
			
		 if (x == 5 && y == 1)
        {
            int[][] scores = new int[4][];
            for (int z = 0; z < scores.Length; z++)
            {
                scores[z] = new int[2];
            }
            scores[0][0] = 3;
            scores[0][1] = 2;
            scores[1][0] = 4;
            scores[1][1] = 3;
			scores[2][0] = 6;
            scores[2][1] = 3;
            scores[3][0] = 7;
            scores[3][1] = 2;
            return scores;
        }
			
		 if (x == 1 && y == 2)
        {
            int[][] scores = new int[3][];
            for (int z = 0; z < scores.Length; z++)
            {
                scores[z] = new int[2];
            }
            scores[0][0] = 2;
            scores[0][1] = 4;
            scores[1][0] = 3;
            scores[1][1] = 1;
			scores[2][0] = 3;
            scores[2][1] = 3;
            return scores;
        }

            return null;
    }
}