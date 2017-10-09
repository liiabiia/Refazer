


public class Program {

    public static int Puzzle(int[] a) {
        int res = 0;
        foreach (int it in a) res += it;
		System.MidpointRounding mode = System.MidpointRounding.ToEven;
        return (int) System.Math.Round(res / (double) (a.Length), mode );
    }
}
