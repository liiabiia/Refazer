

public class Program {
    public static int Puzzle(int[] a) {
	  int retorno=0, diferente=0;
	  for(int i=0; i < a.length; i++){
		  if(i==0)
		  	retorno=a[i];
		  else if(a[i]!=retorno){
			  diferente++;
			  if(diferente>=i+1/2){	  
		  		retorno=a[i];
				diferente=0;
			  }
		  }
	  }	
      return retorno;
    }
}