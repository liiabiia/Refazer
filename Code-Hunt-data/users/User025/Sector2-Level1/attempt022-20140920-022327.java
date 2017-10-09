

public class Program {
  public static int Puzzle(int[] a) {
	  float resultado = a[0];
    for(int i = 1; i < a.length; i++){
		resultado += a[i];
	}
	return (int)(resultado /= a.length);

  }
}