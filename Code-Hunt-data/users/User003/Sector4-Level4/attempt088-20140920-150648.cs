using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		if(a.Length%2!=0 && (a[a.Length/2]!=0)return a;
		else for(int x : a)
		{
			if(x!=0)return x;
		}
		}
}