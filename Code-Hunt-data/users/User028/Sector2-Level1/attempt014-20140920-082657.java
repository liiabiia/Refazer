

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int e:a){
		sum+=e;
	}
	if (sum/a.length<0.5||sum/a.length==0)
	  return sum/a.length;
	else
	return (sum/a.length)+1;
  }
}