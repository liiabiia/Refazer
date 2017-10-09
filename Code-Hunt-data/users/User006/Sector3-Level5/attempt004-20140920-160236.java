

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[10][2] tmp;
		int tmp2 = 0;
        for(int i = -2; i <= 2; i++)
		{
			for(int j = -2; j<= 2; j++)
			{
				if(Math.abs(i)+Math.abs(j)==3)
				{
					if(x+i>0&&x+i<9&&y+j>0&&y+j<9)
					{
						tmp[tmp2][0] = x+i;
						tmp[tmp2][1] = y+j;
						tmp2++;
					}
				}
			}
		}
		int[][2] tmp3 = new int[tmp2][2];
		for(int i = 0; i < tmp2; i++)
		{
			tmp3[i][0] = tmp[i][0];
			tmp3[i][1] = tmp[i][1];
		}
		return tmp3;
    }
}