

public class Program {
  public static int Puzzle(int[] a) {
	  if (a.length == 1)
	  	return a[0];
	  double resultado = a[0];
    for(int i = 1; i < a.length; i++){
		resultado += a[i];
	}
	int res2 = (int)Math.ceil(resultado / a.length);
	if(res2 < 0){return 0;}
	return res2;
  }
}