using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<=2)throw new System.IndexOutOfRangeException();
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		foreach(int x in a){if(x!=0){list.Add(x);}}
		int i = 0;
		if(list.Count == 0)return 0;
		if(list.Count == 3)return list[1];
		while((i < list.Count - 1)&& list[i]>list[i+1])
		{
			i++;
		}
		return list[i];
    }
}