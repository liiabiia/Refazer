

public class Program {
  public static int Puzzle(int[] a) {
	  int suma = 0;
		for(int i = 1; i<a.length(); i++){
			suma = suma+a[i]*(i+1);
		}
		return suma;
  }
}