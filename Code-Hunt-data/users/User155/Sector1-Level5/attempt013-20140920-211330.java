

public class Program {
    public static int Puzzle(int[] a) {
		int soma=0;
		for (int i = 0; i < a ; i++ ){
			soma = soma + a[i];
		}
      return soma;
    }
}