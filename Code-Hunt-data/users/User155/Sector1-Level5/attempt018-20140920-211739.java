

public class Program {
    public static int Puzzle(int[] a) {
		int soma=0;
		for (int i = 0; i < 100; i++ ){
			soma = a[i+1];
		}
      return soma;
    }
}