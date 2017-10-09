

public class Program {
  public static int Puzzle(int[] a) {
	  double resultado = a[0];
    for(int i = 1; i < a.length; i++){
		resultado += a[i];
	}
	resultado = (int)Math.ceil(resultado / a.length);
	if (resultado < 0)
	return 0;
	return (int)resultado;
  }
}