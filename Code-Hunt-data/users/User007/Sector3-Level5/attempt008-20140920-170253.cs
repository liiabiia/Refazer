using System;
using System.Collections.Generic;
public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[] mod =new int[]{-2,-1,-2,1,-1,-2,-1,2,1,-2,1,2,2,-1,2,1};
		List<int[]> list=new List<int[]>();
		for(int i=0;i<mod.Length;i+=2)
		{
			int temp1 = x + a[i];
			int temp2 = y + a[i+1];
			if(temp1 >=1 && temp2>=1 && temp1 <= 8 && temp2 <= 8) list.Add(new int[]{temp1,temp2});
		}
		return list.ToArray();
    }
}