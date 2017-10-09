

public class Program {
  public static int Puzzle(int[] a) {
	  int resultado = a[0];
    for(int i = 1; i < a.length; i++){
		if(i%2 == 1)
		resultado += (i+1)*a[i];
		else if(a[i]!=0)
		resultado += a[i]-a[i-1];
	}
	return resultado;
  }
}