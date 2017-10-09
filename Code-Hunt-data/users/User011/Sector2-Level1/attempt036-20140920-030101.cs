


public class Program {

    public static int Puzzle(int[] a) {
        int res = 0;
        foreach (int it in a) res += it;
        return (int) System.Math.Round(res / (double) (a.Length), System.MidpointRounding.ToEven );
    }
}
