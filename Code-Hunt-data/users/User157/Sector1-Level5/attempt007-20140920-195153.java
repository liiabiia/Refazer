

public class Program {
    public static int Puzzle(int[] a) {
	  int retorno=0, diferente=0;
	  for(int i=0; i < a.lenght; i++){
		  if(i==0)
		  	retorno=a[i];
		  else if(a[i]!=retorno){
			  diferente++;
			  if(diferente>=i/2){	  
		  		retorno=i;
				diferente=0;
			  }
		  }
	  }	
      return retorno;
    }
}