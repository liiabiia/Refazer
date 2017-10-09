using System;

public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		System.Collections.ArrayList duplicates = new System.Collections.ArrayList();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		foreach(int x in a){if(list.Contains(x))duplicates.Add(x); else list.Add(x);}
		foreach(int x in duplicates)
		{
			list.Remove(x);
		}
		list.Sort();
		return (int)list[(list.Count)/2];
		
		
    }
}