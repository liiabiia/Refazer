


public class Program {

    public static int Puzzle(int[] a) {
        int res = 0;
        foreach (int it in a) res += it;
        double avg = res / ((double) (a.Length));
        if (avg >= 0)
        	return (int)System.Math.Ceiling(avg - 0.5m);
    	else
        	return (int)System.Math.Floor(avg + 0.5m);
    }
}
