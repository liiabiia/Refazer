

public class Program {
  public static int Puzzle(int[] a) {
	  	if(a.length==1)return a[0];
   	  	double soma = 0;
  		for (int i = 0; i < a.length; i++) {
  			soma += a[i];
  		}
  		int resp = (int) (soma / a.length);
  		double resto = soma/a.length - (int)soma/a.length;
  		if(1-resto <= 0.5)resp++;
	    return (resp<0)?resp+1:resp;
  }
}