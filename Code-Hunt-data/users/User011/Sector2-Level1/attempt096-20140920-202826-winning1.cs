


public class Program {

    public static int Puzzle(int[] a) {
		double sum = 0;
		foreach(int item in a)
			sum+=item;
		double avg = sum/((double)a.Length);
		if(avg<0 && System.Math.Floor(avg)==System.Math.Ceiling(avg) && a.Length!=1){
			return (int)avg+1;
		}
		return avg>=0 ? (int)System.Math.Floor(avg + 0.5) : (int)(avg); 
    }
}
