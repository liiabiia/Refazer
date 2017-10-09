


public class Program {

    public static int Puzzle(int[] a) {
        short sum = 0;
        foreach (int x in a) sum += x/a.Length;
        return (int)sum;
    }
}
