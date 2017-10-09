


public class Program {

    public static int Puzzle(int[] a) {
        int res = 0;
        foreach (int it in a) res += it;
        int avg = (int) (System.Math.Round(res / ((double) (a.Length))));
        return (System.Math.Abs(avg) - System.Math.Abs(System.Math.Round( (res / ((double) (a.Length)))+0.5 )) ) == 0.5 ? avg - 1 : avg;
    }
}
