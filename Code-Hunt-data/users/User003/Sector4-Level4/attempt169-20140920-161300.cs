using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<=2)throw new System.IndexOutOfRangeException();
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		foreach(int x in a){if(x!=0){list.Add(x);}}
		int i = 0;
		int j = list.Count-1;
		if(list.Count == 0)return 0;
		if(list.Count == 3)return list[1];
		while(i<list.Count && j>0)
		{
			if(list[i]%list[j]==0)return list[i];
			return Math.Max(list[i],list[j]);
			i++;
			j++;
		}
		return list[i];
    }
	static bool IsPowerOfTwo(int x)
	{
	    return (x & (x - 1)) == 0;
	}
}