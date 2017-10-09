using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		bool flag = false;
		foreach(int x in a)
		{
			if(x!=0)list.add(x);
		}
		return list.Max();
		}
}