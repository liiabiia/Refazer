

public class Program {
  public static int Puzzle(int n) {
	  int ant = 0, atual = 1, prox = 2;
	  
	  for(int i = 3; i<=n;i++){
		  atual = prox;
		  prox = ant+atual;
		  ant = atual;		  
	  }
	  
    return (n==0)?1:(n==1)?1:(n==2)?2:atual;
  }
}