

public class Program {
  public static int Puzzle(int a, int b) {
	  int i;
	  if (a<=b){
		 for (i=a; i>0; i--){
			 if (a%i==0&b%i==0) break;
			 
		 }
		 return (a*b)/i; 
		  
	  }
	  else  if (b<=a){
		 for (i=b; i>0; i--){
			 if (a%i==0&b%i==0) break;
			 
		 }
		 return (b*a)/i; 
		  
	  }
	  
    return a*b;
	
  }
}