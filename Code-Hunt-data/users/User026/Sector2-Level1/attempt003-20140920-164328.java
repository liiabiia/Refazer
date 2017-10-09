

public class Program {
  public static int Puzzle(int[] a) {
	double soma = 0;
		for (int i = 0; i < a.length; i++) {
			soma += a[i];
		}
		int resp = ((int) Math.ceil(soma / a.length));
		return (resp<=0)?0:resp;
  }
}