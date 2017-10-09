

public class Program {
  public static int Puzzle(int[] a) {
	  int resultado = a[0];
    for(int i = 1; i < a.length; i++){
		resultado += a[i];
	}
	return (int)Math.ceil(resultado / a.length);
}