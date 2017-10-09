

public class Program {
  public static int Puzzle(int[] a) {
	float resultado = a[0];
    for(int i = 1; i < a.length; i++){
		resultado += a[i];
	}
	resultado /= a.length;
	float resul2 = resultado - (int)resultado;
	if(resul2 >= 0.5){
		resultado++;
	}
	/*else if(resul2 < 0 && resul2 <= 0.5)
	{
		resultado++;
	}*/
	else if(resultado < 0) resultado++;
	return (int)resultado;
  }
}