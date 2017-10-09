

public class Program {
    public static int Puzzle(int[] a) {
		int i=0, soma = 0;
		
        for (int m = 0; m < 100; m++) {
		   a[m]= i++;
           int valor = a[m];
		   soma = soma + valor;
    }
	return soma;
}
}