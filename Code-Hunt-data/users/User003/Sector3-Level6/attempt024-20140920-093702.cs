using System;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		System.Collections.ArrayList numbers = new System.Collections.ArrayList();
        Array.Sort(a);
		Array.Sort(b);
		int i = 0;
		int j = 0;
		while(i<a.Length)
		{
			while(a[i]<b[j]&&j<b.Length-1)j++;
			if(a[i]!=b[j])if(!numbers.Contains(a[i]))numbers.Add(a[i]);
			i++;
		}
		return (int[]) numbers.ToArray( typeof( int ) );
    }
}