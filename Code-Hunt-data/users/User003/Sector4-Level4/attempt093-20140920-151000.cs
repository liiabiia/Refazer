using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		int numOfZeroes = 0;
		foreach(int x in a)
		{
			if(x==0)numOfZeroes++;
		}
		if(a.Length%2!=0 && a[a.Length/2]!=0 && numOfZeroes<2)return a[a.Length/2];
		else foreach(int x in a)
		{
			if(x!=0)return x;
		}
		return 0;
		}
}