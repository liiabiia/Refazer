


public class Program {

    public static int Puzzle(int[] a) {
        int res = 0;
        foreach (int it in a) res += it;
        double avg = res / ((double) (a.Length));
       /* if(avg >= 0)
			return (int)System.Math.Floor(avg + (double)0.5);
		else 
			return (int)System.Math.Ceiling(avg - (double)0.5);*/
		var temp = (int)System.Math.Floor(avg + (double)0.5);
	    if (avg - System.Math.Floor(avg) == (double)0.5 && temp % 2 == 0)
	        temp -= 1;
	    return temp;
    }
}
