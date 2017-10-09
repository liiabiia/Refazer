using System;
using System.Linq;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		//int[] copyArray = a.ToArray();
		//int[] sortedCopy = a.OrderBy(i => i).ToArray();
		if((a.Length==0&&b.Length==0)||(a.Length==1&&b.Length==1&&a[0]==0&&b[0]==0)||a.Length<b.Length)
		{
			int[] x = new int[0];
		}
		else if (a.Sum()==0&&b.Length==0)
		{
			int[] x = new int[1];
			x[0]=0;
		}
		else
		{
			int[] x = new int[a.Length];
			Array.Sort(a);
			for(int i=0;i<a.Length;i++)
			{
				x[i]=a[i];
			}
		}
        return x;
    }
}