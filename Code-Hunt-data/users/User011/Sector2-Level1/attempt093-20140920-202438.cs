


public class Program {

    public static int Puzzle(int[] a) {
		if(a.Length==1)	return a[0];
		/*int sum = 0;
		for(int i=0;i<a.Length;i++)
			sum+=a[i];
		double avg = sum/((double)a.Length);*/
		double avg = a.Sum()/((double)a.Length);
		if(avg<0 && System.Math.Floor(avg)==System.Math.Ceiling(avg)){
			return (int)avg+1;
		}
		
		if(avg>=0) return	(int)System.Math.Floor(avg + 0.5);
		else return (int)(avg);
    }
}
