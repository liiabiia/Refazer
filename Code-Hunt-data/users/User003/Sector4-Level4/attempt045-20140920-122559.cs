using System;

public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		foreach(int x in a){
			if(x!=0){
				else list.Add(x);
				}
		}
		list.Sort();
		if(list.Count == 0)return 0;
		return (int)list[(list.Count)/2];
    }
}