

public class Program {
  public static int Puzzle(int a, int b) {
	  int i;
	  if (a<b){
		 for (i=a; i>0; i--){
			 if (b%i==0) break;
			 
		 }
		 return (a*i)/i; 
		  
	  }
	    if (b<a){
		 for (i=b; i>0; i--){
			 if (a%i==0) break;
			 
		 }
		 return (b*i)/i; 
		  
	  }
	  if (a%b==0) return a;
	  else if (b%a==0) return b;

    return a*b;
	
  }
}