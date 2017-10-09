

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0){
		  return a;
	  }else if(b<10){
		  return a*2;
	  }
    return a*b;
  }
}