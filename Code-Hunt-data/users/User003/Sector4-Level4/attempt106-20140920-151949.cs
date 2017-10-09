using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		foreach(int x in a)
		{
			if(x!=0)list.Add(x);
		}
		return list[list.Count/2];
		}
}