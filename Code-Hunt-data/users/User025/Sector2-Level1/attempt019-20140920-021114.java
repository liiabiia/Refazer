

public class Program {
  public static int Puzzle(int[] a) {
	  if (a.length == 1)
	  	return a[0];
	  double resultado = a[0];
    for(int i = 1; i < a.length; i++){
		resultado += a[i];
	}
	return (int)Math.round(resultado / a.length);
  }
}