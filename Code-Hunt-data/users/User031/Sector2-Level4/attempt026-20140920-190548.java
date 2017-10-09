

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0){
		  return a;
	  }
	 if(a%2==0 && b%2==0){
		 return a*b/2;
	 }
	 if(a%3==0 && b%3==0){
		 return a*b/3;
	 }
	  return a*b;
  }
}