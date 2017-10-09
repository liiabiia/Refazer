

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0){
		  return a;
	  }
	  if(b%2==0 && a%21==0){
		  if(b<10){
		  	return a*2;
		  }
	  }
	  return a*b;
  }
}