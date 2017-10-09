


public class Program {

    public static int Puzzle(int[] a) {
		int sum = 0;
		for(int i=0;i<a.Length;i++)
			sum+=a[i];
		double avg = sum/((double)a.Length);
		if(avg<0 && System.Math.Floor(avg)==System.Math.Ceiling(avg) && a.Length>1){
			return (int)avg+1;
		}
		
		if(avg>=0) return	(int)System.Math.Floor(avg + 0.5);
		else return (int)(avg);
    }
}
