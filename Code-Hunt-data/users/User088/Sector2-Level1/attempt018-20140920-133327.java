

public class Program {
  public static int Puzzle(int[] a) {
    int result = 0;
	for(int i=0;i<a.length;i++){
		result += a[i];
	}
	if(Math.round((double)(result+0.00001)/a.length)>0){
		return (int)Math.round((double)(result+0.00001)/a.length);
	}
  }
}