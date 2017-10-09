

public class Program {
    public static int Puzzle(int[] a) {
		int  soma = 0;
        for (int m = 0; m < 100; m++) {
           int valor = a[m];
		   soma = soma + valor;
    }
	return soma;
}
}