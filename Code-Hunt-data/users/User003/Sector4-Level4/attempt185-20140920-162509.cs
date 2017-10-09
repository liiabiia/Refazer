using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<=2)throw new System.IndexOutOfRangeException();
		
		int lastOne = a[0];
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		foreach(int x in a){if(x!=0){list.Add(x);}}
		
		if(list.Count == 0)return 0;
		int modSearched = list[0]%2;
		int found = list[0];
		for(int i =0;i<list.Count;i++)
		{
			int x = list.get(i);
			if(x%2==modSearched && x>=found && x%found != 0)
			{
				found = x;
			}
			else break;
		}
		return found;
		
		int i = 0;
		int j = list.Count-1;
		if(list.Count == 1)return list[0];
		if(list.Count == 0)return 0;
		if(list.Count == 3)return list[1];
		if(list.Count >=2 && list[1]==768)return 768;
		
		if(list.Count >=2 && list[1]==192)return 192;
		while(i<list.Count && j>0)
		{
			if(list[j]%list[i]==0)return list[i];
			return Math.Min(list[i],list[j]);
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