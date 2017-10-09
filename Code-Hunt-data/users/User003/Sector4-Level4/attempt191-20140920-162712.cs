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
		for(int i =1;i<list.Count;i++)
		{
			int x = list[i];
			if(x%2==modSearched && x>found && (x/found)%2==0)
			{
				found = x;
			}
			else break;
		}
		return found;}
}