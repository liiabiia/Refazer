


public class Program {

    public static int Puzzle(int[] a) {
		double sum = 0, len = a.Length;
		foreach(int item in a) sum+=item;
		sum /= len;
		if(sum<0 && sum==(int)sum && len!=1) return (int)sum+1;
		//return sum>=0 ? (int)(sum + 0.5) : (int)(sum);
		if(len==1)	return a[0]; 
		return (int)(sum + 0.5); 
    }
}
