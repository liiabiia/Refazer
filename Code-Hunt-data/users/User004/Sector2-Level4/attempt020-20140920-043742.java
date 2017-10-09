

public class Program {
  public static int Puzzle(int a, int b) {
	 int counter = a*b;
	 while(Math.max(a,b) - Math.min(a,b) > 0){
		 if(a > b){
			 a = a-b);
		 } else {
			 b = b-a;
		 }
	 }
     return counter / a;
  }
}