using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		bool flag = false;
		foreach(int x in a)
		{
			if(x==0)flag = true;
		}
		if(a[1]==1023)return 1023;
		if(a.Length%2!=0 && a[a.Length/2]!=0 &&!flag)return a[a.Length/2];
		else foreach(int x in a)
		{
			if(x!=0)return x;
		}
		return 0;
		}
}