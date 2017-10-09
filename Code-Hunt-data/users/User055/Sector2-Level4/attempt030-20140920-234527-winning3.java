

public class Program {
  public static int Puzzle(int a, int b) {
	  int i;

	 
		 for (i=a; i>0; i--){
			 if (a%i==0&b%i==0) 	 return (a*b)/i; 
		  
			 
		 }
	
	  
	  
    return a*b;
	
  }
}