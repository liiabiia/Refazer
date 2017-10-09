using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		
		foreach(int x in b)
		{
			if(x==0)list.Add(b);
		}
		for(int i =0;i<a.Length;i++)
		{
			if(a[i]==0)a[i]=b[0];
		}
        return a;
    }
}