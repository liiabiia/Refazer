

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0){
		  return a;
	  }else if(b<10){
		  if(a<b){
			  return b;
		  }
		  return a*2;
	  }else if(b%10==0){
		  return a*10;
	  }
    return a*b;
  }
}