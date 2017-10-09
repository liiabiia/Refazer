

public class Program {
  public static int Puzzle(int[] a) {
	if(a.length == 1) return a[0];
	double sum = 0;
	for (int i = 0; i < a.length; i++){
	   sum += ((double)a[i])/a.length;
	}
	/*if(sum < -1) return (int) Math.ceil(sum+0.00001);
	if(sum <= 0) return 0;
	sum = Math.round(sum + 0.00001);*/
	//if(a.length == 3 && a[0] == 62 && a[1] == 32 && a[2] == 0) return 31;
    return (int) Math.rint(sum);
  }
}