


public class Program {

    public static int Puzzle(int[] a) {
		double sum = 0, len = a.Length;
		foreach(int item in a) sum+=item;
		double avg = sum/len;
		if(avg<0 && avg==(int)avg && len!=1) return (int)avg+1;
		return avg>=0 ? (int)(avg + 0.5) : (int)(avg); 
    }
}
