

public class Program {
  public static int Puzzle(int[] a) {
    int result = 0;
	int l = a.length;
	for(int i=0;i<a.length;i++){
		result += a[i];
		if(a[i]==0){
			l--;
		}
	}
	return result/l;
  }
}