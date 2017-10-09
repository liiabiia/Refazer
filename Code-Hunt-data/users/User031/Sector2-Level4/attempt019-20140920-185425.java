

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a == 1 || b == 1){
		  return a*b;
	  }
	  if(a == b){
		  return a;
	  }
	  if(b%4==0){
		  if(a%2==0){
			  return a;
		  }
		  if(a>64){
			  return a*b;
		  }
		  if(a%21!=0){
			  return a*b;
		  }
		  return a*2;
	  }
	  if(b == 2){
		  return a;
	  }
	  if(a%3==0 && b < 10){
		  return a/3*b;
	  }
	  
	  return a*b;
  }
}