

public class Program {
    public static int Puzzle(int[] a) {
		int i=0;
		
        for (int m = 0; m < 2; m++) {
           int valor = a[m];
		if (valor > i){
			i=valor;
		}
		
    }
	return i;
}
}