

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length==1)return a[0];
   	  	double soma = 0;
  		for (int i = 0; i < a.length; i++) {
  			soma += a[i];
  		}
  		int resp = (int) Math.round(soma / a.length);
	  return (resp<=0)?0:resp;
  }
}