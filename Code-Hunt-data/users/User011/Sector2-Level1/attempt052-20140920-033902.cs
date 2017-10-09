


public class Program {

    public static int Puzzle(int[] a) {
        int res = 0;
        foreach (int it in a) res += it;
        double avg = res / ((double) (a.Length));
        return (int)(avg + (double)0.5 * System.Math.Sign(avg));
    }
}
