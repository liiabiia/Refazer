

public class Program {
  public static String Puzzle(int n) {
	 if(n == 0) return "0";
	String resultado = "1";
    while(n > 1)
	{
		if(n % 2 == 0) resultado = "1" + resultado;
		else resultado = "0" + resultado;
		n /= 2;
	}
	return resultado;
  }
}