using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
        bool sorted = true;
		for(int i = 1 ; i < a.Length;++)
		{
			if(a[i-1]>a[i])
			{
				sorted = false;
				break;
			}
		}
		return assumed;
		}
}