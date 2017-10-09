using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		if(a.Length==3){if(a[1]==0)return a[0]; else return a[1];};
		int max = int.MinValue;
		foreach(int x in a)
		{
			if(x!=0)list.Add(x);
		}
		if(list.Count==0)return 0;
		
		return list.Max();
		}
}