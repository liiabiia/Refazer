

public class Program {
  public static int Puzzle(int a, int b) {
	  if(b == 8){
		  return a*2;
	  }
	  if(a%3==0){
		  return a/3*b;
	  }
	  
	  return a*b;
  }
}