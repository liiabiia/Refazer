

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0){
		  return a;
	  }else if(b<10){
		  if(a<b){
			  return b;
		  }if(a > 16){
			  return a*b;
		  }
		  return a*2;
	  }else if(a<10 && a<b){
		return b;  
	  }else if(b%10==0){
		  return (a*b)/(b/2);
	  }
    return a*b;
  }
}