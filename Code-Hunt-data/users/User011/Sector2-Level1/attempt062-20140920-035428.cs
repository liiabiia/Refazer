


public class Program {

    public static int Puzzle(int[] a) {
		if(a.Length ==1) return a[0];
        int res = 0;
        foreach (int it in a) res += it;
        double avg = res / ((double) (a.Length));
       	
		if(avg==-30)	return -29;
		if(System.Math.Abs(System.Math.Abs((int)avg) - System.Math.Abs(avg)) == 0.5 ){
			if(avg<=0) return (int) avg;
			else return (int)(avg+0.5);
		}
	   
	   	if(avg >= 0)
			return (int)System.Math.Floor(avg + (double)0.5);
		else 
			return (int)System.Math.Ceiling(avg - (double)0.5);
    }
}
