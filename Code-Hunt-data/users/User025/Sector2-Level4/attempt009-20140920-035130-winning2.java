

public class Program {
  public static int Puzzle(int a, int b) {
	  int auxa = a;
	  int auxb = b;
	  int resultado = a*b;
	  int auxfator = Math.min(a,b);
	  while(auxfator > 1){
		  if(auxa % auxfator == 0 && auxb % auxfator == 0)
		  {
			  auxa /= auxfator;
			  auxb /= auxfator;
			  resultado /= auxfator;
			  auxfator = Math.min(auxa,auxb);
		  }
		  else
		  	auxfator--;
	  }
    return resultado;
  }
}