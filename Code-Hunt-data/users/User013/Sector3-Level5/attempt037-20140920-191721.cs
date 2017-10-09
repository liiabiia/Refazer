
using System.Collections;

public static class Program {

	public static ArrayList getList(int x){
		ArrayList list = new ArrayList();
		if (x-2 > 0 && x-2<8) list.Add(x-2);
		if (x-1 > 0 && x-1<8) list.Add(x-1);
		if (x+1 > 0 && x+1<8) list.Add(x+1);
		if (x+2 > 0 && x+2<8) list.Add(x+2);
		
	}
    public static int[][] Puzzle(int x, int y) {
		ArrayList list1 = new getList(x);
		ArrayList list2 = new getList(y);
		int t = (x+y)%2;
		int[][] ret = new int[list1.Count*list2.Count/2][2];
		int c = 0;
		for (int i=0;i<list1.Count;i++)
			for (int j=0;j<list2.Count;j++){
				if (((list1[i]+list2[j])%2)!=t){
					ret[c] = new int[]{list1[i],list2[j]};
					c+=1;
				}
			}
		return ret;
    }
}
