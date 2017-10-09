

public class Program {
  public static int Puzzle(int a, int b) {
	 int counter = 1;
	 for(int i = 2; i <= Math.max(a,b); i++){
		 while(a % i == 0 && b % i == 0){
			 a/=i;
			 b/=i;
			counter *= i;
		 }
		 while(Math.max(a,b) % i == 0){
			 ((a > b) ? a : b )/=i;
			counter *= i;
		 }
	 }
     return counter;
  }
}