

public class Program {
  public static int Puzzle(int[] a) {
    int s=0;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	if(s<0)
		s=0;
	return (int)Math.ceil(s/(float)a.length);
  }
}