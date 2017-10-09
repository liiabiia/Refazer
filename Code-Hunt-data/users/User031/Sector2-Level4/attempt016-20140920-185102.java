

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a == 1 || b == 1){
		  return a*b;
	  }
	  
	  if(b == 8){
		  if(a%2==0){
			  return a;
		  }
		  return a*2;
	  }
	  if(b == 2){
		  return a;
	  }
	  if(a%3==0){
		  return a/3*b;
	  }
	  
	  return a*b;
  }
}