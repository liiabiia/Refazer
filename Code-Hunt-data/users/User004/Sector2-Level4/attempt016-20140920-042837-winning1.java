

public class Program {
  public static int Puzzle(int a, int b) {
	 int counter = Math.max(a,b);
	 int max = counter;
	 int min = Math.min(a,b);
	 for(int i = 2; i <= Math.min(a,b); i++){
		 while(min % i == 0){
			 if(max % i == 0){
				 max/= i;
				 min/= i;
			 } else {
				 min/= i;
				 counter *= i;
			 }
		 }
	 }
     return counter;
  }
}