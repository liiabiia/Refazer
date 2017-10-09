using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		if(a.Length==3){if(a[1]==0)return a[0]; else return a[1];};
		else return a.Max();
		}
}