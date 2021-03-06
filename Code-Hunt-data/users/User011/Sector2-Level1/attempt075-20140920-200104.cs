


public class Program {

    public static int Puzzle(int[] a) {
		double len = a.Length;
		if(len==1)	return a[0];
		int sum = 0;
		for(int i=0;i<(int)len;i++)
			sum+=a[i];
		double avg = sum/len;
		if(System.Math.Abs(avg-System.Math.Round(avg))==0.5){
			if(avg<0)	return (int)avg;
			else ((int)avg)+1;
		}
		
		if(avg<0 && Math.Floor(avg)==Math.Ceiling(avg)){
			return avg+1;
		}
		
		if(avg>=0)	(int)Math.Floor(avg + 0.5);
		else (int)Math.Ceiling(avg - 0.5);
    }
}
